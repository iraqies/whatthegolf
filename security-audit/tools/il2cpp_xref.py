#!/usr/bin/env python3
"""Cross-reference index for an IL2CPP ARM64 binary, built from raw machine code.

Il2CppDumper gives names and addresses (script.json) but no "who calls what".
This tool decodes every instruction of the code sections and records:
  - direct calls and tail calls (BL / B imm26) -> callee method names
  - ADRP + LDR/ADD pairs that land on a string-literal slot, a TypeInfo slot
    or a MethodInfo slot -> the literal / type / method each method touches

Usage:
  il2cpp_xref.py build   <UnityFramework> <script.json> <index.pkl>
  il2cpp_xref.py callers <index.pkl> <callee-regex>
  il2cpp_xref.py strings <index.pkl> <literal-regex>
  il2cpp_xref.py types   <index.pkl> <typeinfo-regex>
  il2cpp_xref.py summary <index.pkl> <method-regex>
"""
import json
import pickle
import re
import sys
from collections import defaultdict

import numpy as np


def sx(v, bits):
    m = 1 << (bits - 1)
    return (v ^ m) - m


def code_ranges(binary_path):
    import lief
    lief.logging.disable()
    b = lief.MachO.parse(binary_path).at(0)
    out = []
    for seg in b.segments:
        for s in seg.sections:
            if seg.name == "__TEXT" and s.name in ("__text", "il2cpp"):
                out.append((s.virtual_address, s.offset, s.size))
    return out


def build(binary_path, script_json, index_path):
    sj = json.load(open(script_json))
    names = {}
    for m in sj["ScriptMethod"]:
        names.setdefault(m["Address"], m["Name"])
    starts = sorted(set(sj["Addresses"]) | set(names))
    strings = {s["Address"]: s["Value"] for s in sj["ScriptString"]}
    typeinfo = {s["Address"]: s["Name"] for s in sj["ScriptMetadata"]}
    methodinfo = {s["Address"]: s["Name"] for s in sj["ScriptMetadataMethod"]}
    data = open(binary_path, "rb").read()

    calls = defaultdict(set)
    str_refs = defaultdict(set)
    type_refs = defaultdict(set)
    minfo_refs = defaultdict(set)
    starts_arr = np.array(starts, dtype=np.int64)

    for va, off, size in code_ranges(binary_path):
        words = np.frombuffer(data, dtype="<u4", count=size // 4, offset=off).astype(np.int64)
        pcs = va + 4 * np.arange(words.size, dtype=np.int64)
        owner_idx = np.searchsorted(starts_arr, pcs, side="right") - 1

        is_bl = (words & 0xFC000000) == 0x94000000
        is_b = (words & 0xFC000000) == 0x14000000
        for mask in (is_bl, is_b):
            idx = np.nonzero(mask)[0]
            imm = words[idx] & 0x3FFFFFF
            imm = np.where(imm & 0x2000000, imm - 0x4000000, imm)
            tgt = pcs[idx] + imm * 4
            for i, t in zip(idx.tolist(), tgt.tolist()):
                callee = names.get(t)
                if callee is None:
                    continue
                o = owner_idx[i]
                if o < 0:
                    continue
                caller = starts[o]
                if caller == t:
                    continue
                calls[caller].add(t)

        is_adrp = (words & 0x9F000000) == 0x90000000
        for i in np.nonzero(is_adrp)[0].tolist():
            w = int(words[i])
            rd = w & 0x1F
            imm = ((w >> 29) & 0x3) | (((w >> 5) & 0x7FFFF) << 2)
            page = (int(pcs[i]) & ~0xFFF) + (sx(imm, 21) << 12)
            for j in range(i + 1, min(i + 9, words.size)):
                w2 = int(words[j])
                rn = (w2 >> 5) & 0x1F
                if rn != rd:
                    continue
                if (w2 & 0xFFC00000) == 0xF9400000:      # LDR Xt, [Xn, #imm12*8]
                    addr = page + (((w2 >> 10) & 0xFFF) << 3)
                elif (w2 & 0xFF800000) == 0x91000000:    # ADD Xd, Xn, #imm12{, lsl 12}
                    sh = (w2 >> 22) & 1
                    addr = page + (((w2 >> 10) & 0xFFF) << (12 * sh))
                else:
                    continue
                o = owner_idx[i]
                if o < 0:
                    break
                owner = starts[o]
                if addr in strings:
                    str_refs[owner].add(addr)
                elif addr in typeinfo:
                    type_refs[owner].add(addr)
                elif addr in methodinfo:
                    minfo_refs[owner].add(addr)
                break

    idx = dict(names=names, starts=starts, strings=strings, typeinfo=typeinfo, methodinfo=methodinfo,
               calls=dict(calls), str_refs=dict(str_refs), type_refs=dict(type_refs), minfo_refs=dict(minfo_refs))
    pickle.dump(idx, open(index_path, "wb"))
    n_calls = sum(len(v) for v in calls.values())
    print(f"methods {len(names)}  call edges {n_calls}  methods using literals {len(str_refs)}  "
          f"methods touching TypeInfo {len(type_refs)}  methods touching MethodInfo {len(minfo_refs)}")


def load(p):
    return pickle.load(open(p, "rb"))


def nm(idx, a):
    return idx["names"].get(a, f"sub_{a:x}")


def cmd_callers(idx, rx):
    r = re.compile(rx)
    targets = {a for a, n in idx["names"].items() if r.search(n)}
    out = defaultdict(set)
    for caller, callees in idx["calls"].items():
        for c in callees & targets:
            out[nm(idx, c)].add(caller)
    for minfo_addr, n in idx["methodinfo"].items():
        if r.search(n):
            for owner, refs in idx["minfo_refs"].items():
                if minfo_addr in refs:
                    out[f"[minfo] {n}"].add(owner)
    for tgt, callers in sorted(out.items()):
        print(f"=== {tgt} ({len(callers)} callers) ===")
        for c in sorted(callers):
            print(f"  0x{c:x}  {nm(idx, c)}")


def cmd_strings(idx, rx):
    r = re.compile(rx)
    for owner, addrs in sorted(idx["str_refs"].items()):
        hits = [idx["strings"][a] for a in sorted(addrs) if r.search(idx["strings"][a])]
        if hits:
            print(f"0x{owner:x}  {nm(idx, owner)}")
            for h in hits:
                print(f"    str: {h!r}")


def cmd_types(idx, rx):
    r = re.compile(rx)
    for owner, addrs in sorted(idx["type_refs"].items()):
        hits = [idx["typeinfo"][a] for a in sorted(addrs) if r.search(idx["typeinfo"][a])]
        if hits:
            print(f"0x{owner:x}  {nm(idx, owner)}")
            for h in hits:
                print(f"    type: {h}")


def cmd_summary(idx, rx):
    r = re.compile(rx)
    for a, n in sorted(idx["names"].items()):
        if not r.search(n):
            continue
        print(f"=== 0x{a:x}  {n} ===")
        for c in sorted(idx["calls"].get(a, ())):
            print(f"  call -> 0x{c:x}  {nm(idx, c)}")
        for m in sorted(idx["minfo_refs"].get(a, ())):
            print(f"  minfo -> {idx['methodinfo'][m]}")
        for t in sorted(idx["type_refs"].get(a, ())):
            print(f"  type  -> {idx['typeinfo'][t]}")
        for s in sorted(idx["str_refs"].get(a, ())):
            print(f"  str   -> {idx['strings'][s]!r}")


def main():
    cmd = sys.argv[1]
    if cmd == "build":
        build(sys.argv[2], sys.argv[3], sys.argv[4])
    elif cmd == "callers":
        cmd_callers(load(sys.argv[2]), sys.argv[3])
    elif cmd == "strings":
        cmd_strings(load(sys.argv[2]), sys.argv[3])
    elif cmd == "types":
        cmd_types(load(sys.argv[2]), sys.argv[3])
    elif cmd == "summary":
        cmd_summary(load(sys.argv[2]), sys.argv[3])


if __name__ == "__main__":
    main()
