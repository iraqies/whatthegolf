#!/usr/bin/env python3
"""Parse the embedded code signature of a Mach-O and verify every page hash.

Usage: codesig_check.py <macho> [--entitlements-out FILE] [--cms-out FILE]

For each CodeDirectory it prints identifier, team ID, flags, hash type and
special slots, then recomputes the hash of every code page and of the
special-slot inputs (Info.plist, CodeResources, entitlements, requirements)
that are available next to the binary. Mismatching pages are listed so you
can see exactly which byte ranges changed after the binary was signed.
"""
import argparse
import hashlib
import os
import struct
import sys

import lief

CSMAGIC_EMBEDDED_SIGNATURE = 0xFADE0CC0
CSMAGIC_CODEDIRECTORY = 0xFADE0C02
CSMAGIC_REQUIREMENTS = 0xFADE0C01
CSMAGIC_EMBEDDED_ENTITLEMENTS = 0xFADE7171
CSMAGIC_EMBEDDED_DER_ENTITLEMENTS = 0xFADE7172
CSMAGIC_BLOBWRAPPER = 0xFADE0B01

SLOT_NAMES = {
    0: "CodeDirectory",
    1: "InfoSlot",
    2: "Requirements",
    3: "ResourceDir",
    4: "Application",
    5: "Entitlements",
    7: "DER-Entitlements",
    0x1000: "AlternateCodeDirectory0",
    0x1001: "AlternateCodeDirectory1",
    0x1002: "AlternateCodeDirectory2",
    0x10000: "CMS-Signature",
}

HASH_TYPES = {1: ("sha1", 20), 2: ("sha256", 32), 3: ("sha256_truncated", 20), 4: ("sha384", 48)}

CS_FLAGS = {
    0x1: "VALID", 0x2: "ADHOC", 0x4: "GET_TASK_ALLOW", 0x8: "INSTALLER",
    0x10: "FORCED_LV", 0x20: "INVALID_ALLOWED", 0x100: "HARD", 0x200: "KILL",
    0x400: "CHECK_EXPIRATION", 0x800: "RESTRICT", 0x1000: "ENFORCEMENT",
    0x2000: "REQUIRE_LV", 0x4000: "ENTITLEMENTS_VALIDATED", 0x8000: "NVRAM_UNRESTRICTED",
    0x10000: "RUNTIME", 0x20000: "LINKER_SIGNED",
}


def hfunc(htype):
    name, size = HASH_TYPES[htype]
    if name == "sha1":
        return lambda b: hashlib.sha1(b).digest()
    if name == "sha384":
        return lambda b: hashlib.sha384(b).digest()
    return lambda b: hashlib.sha256(b).digest()[:size]


def flag_names(v, table):
    return [n for bit, n in table.items() if v & bit] or ["none"]


def parse_code_directory(blob):
    magic, length, version, flags, hash_off, ident_off, n_special, n_code, code_limit, \
        hash_size, hash_type, platform, page_size, _spare2 = struct.unpack(">IIIIIIIIIBBBBI", blob[:44])
    cd = dict(magic=magic, length=length, version=version, flags=flags, hash_off=hash_off,
              ident_off=ident_off, n_special=n_special, n_code=n_code, code_limit=code_limit,
              hash_size=hash_size, hash_type=hash_type, platform=platform,
              page_size=(1 << page_size) if page_size else 0)
    off = 44
    if version >= 0x20100:
        cd["scatter_off"], = struct.unpack(">I", blob[off:off + 4]); off += 4
    if version >= 0x20200:
        cd["team_off"], = struct.unpack(">I", blob[off:off + 4]); off += 4
    if version >= 0x20300:
        _spare3, cd["code_limit64"] = struct.unpack(">IQ", blob[off:off + 12]); off += 12
    if version >= 0x20400:
        cd["exec_seg_base"], cd["exec_seg_limit"], cd["exec_seg_flags"] = struct.unpack(">QQQ", blob[off:off + 24]); off += 24
    if version >= 0x20500:
        cd["runtime"], cd["pre_encrypt_off"] = struct.unpack(">II", blob[off:off + 8]); off += 8

    def cstr(o):
        end = blob.index(b"\0", o)
        return blob[o:end].decode(errors="replace")

    cd["identifier"] = cstr(ident_off)
    cd["team_id"] = cstr(cd["team_off"]) if cd.get("team_off") else None
    hs = hash_size
    cd["special"] = {}
    for i in range(1, n_special + 1):
        h = blob[hash_off - i * hs: hash_off - (i - 1) * hs]
        cd["special"][i] = h
    cd["code"] = [blob[hash_off + i * hs: hash_off + (i + 1) * hs] for i in range(n_code)]
    if cd.get("pre_encrypt_off"):
        po = cd["pre_encrypt_off"]
        cd["pre_encrypt"] = [blob[po + i * hs: po + (i + 1) * hs] for i in range(n_code)]
    return cd


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("macho")
    ap.add_argument("--entitlements-out")
    ap.add_argument("--cms-out")
    ap.add_argument("--max-list", type=int, default=50)
    a = ap.parse_args()

    lief.logging.disable()
    fat = lief.MachO.parse(a.macho)
    binary = fat.at(0)
    sig = binary.code_signature
    data = open(a.macho, "rb").read()
    sig_off, sig_size = sig.data_offset, sig.data_size
    sb = data[sig_off: sig_off + sig_size]
    magic, length, count = struct.unpack(">III", sb[:12])
    assert magic == CSMAGIC_EMBEDDED_SIGNATURE, hex(magic)
    print(f"file: {a.macho}")
    print(f"file size: {len(data)}  signature @ {sig_off:#x} size {sig_size:#x} superblob len {length:#x} blobs {count}")
    if sig_off + sig_size != len(data):
        print(f"!! signature does not end at EOF: {len(data) - (sig_off + sig_size)} trailing bytes")

    blobs = {}
    for i in range(count):
        btype, boff = struct.unpack(">II", sb[12 + i * 8: 20 + i * 8])
        bmagic, blen = struct.unpack(">II", sb[boff:boff + 8])
        blobs[btype] = sb[boff: boff + blen]
        print(f"  blob type {btype:#07x} ({SLOT_NAMES.get(btype, '?')}) magic {bmagic:#x} len {blen}")

    bundle_dir = os.path.dirname(os.path.abspath(a.macho))
    info_plist = os.path.join(bundle_dir, "Info.plist")
    code_res = os.path.join(bundle_dir, "_CodeSignature", "CodeResources")

    total_bad = 0
    for btype in sorted(t for t in blobs if t == 0 or 0x1000 <= t < 0x10000):
        cdb = blobs[btype]
        cd = parse_code_directory(cdb)
        hname, _ = HASH_TYPES.get(cd["hash_type"], ("?", 0))
        h = hfunc(cd["hash_type"])
        cdhash_full = hashlib.sha256(cdb).hexdigest() if cd["hash_type"] != 1 else hashlib.sha1(cdb).hexdigest()
        print()
        print(f"CodeDirectory slot {btype:#x}: version {cd['version']:#x} hash {hname} pages {cd['n_code']} x {cd['page_size']} codeLimit {cd['code_limit']:#x}")
        print(f"  identifier: {cd['identifier']}   team: {cd['team_id']}   platform: {cd['platform']}")
        print(f"  flags: {cd['flags']:#x} {flag_names(cd['flags'], CS_FLAGS)}")
        if "exec_seg_flags" in cd:
            print(f"  execSeg base {cd['exec_seg_base']:#x} limit {cd['exec_seg_limit']:#x} flags {cd['exec_seg_flags']:#x}")
        if cd.get("runtime"):
            print(f"  runtime version {cd['runtime']:#x}")
        print(f"  cdhash ({'sha1' if cd['hash_type'] == 1 else 'sha256'}): {cdhash_full}  (first 20 bytes: {cdhash_full[:40]})")
        if cd.get("pre_encrypt_off"):
            print(f"  pre-encrypt hash slots present @ {cd['pre_encrypt_off']:#x}")

        special_inputs = {
            1: open(info_plist, "rb").read() if os.path.exists(info_plist) else None,
            2: blobs.get(2),
            3: open(code_res, "rb").read() if os.path.exists(code_res) else None,
            5: blobs.get(5),
            7: blobs.get(7),
        }
        for slot, stored in sorted(cd["special"].items()):
            name = SLOT_NAMES.get(slot, f"slot{slot}")
            if stored == b"\0" * len(stored):
                print(f"  special {slot} {name}: (empty)")
                continue
            src = special_inputs.get(slot)
            if src is None:
                print(f"  special {slot} {name}: stored {stored.hex()}  (input not available)")
                continue
            ok = h(src) == stored
            print(f"  special {slot} {name}: {'OK' if ok else 'MISMATCH'}  stored {stored.hex()}  actual {h(src).hex()}")

        ps = cd["page_size"]
        limit = cd.get("code_limit64") or cd["code_limit"]
        bad = []
        bad_pre = []
        for i, stored in enumerate(cd["code"]):
            start = i * ps
            chunk = data[start: min(start + ps, limit)]
            actual = h(chunk)
            if actual != stored:
                bad.append(i)
                if "pre_encrypt" in cd and h(chunk) != cd["pre_encrypt"][i]:
                    bad_pre.append(i)
        total_bad += len(bad)
        print(f"  code pages: {cd['n_code']} checked, {len(bad)} mismatching")
        if bad:
            ranges = []
            s = p = bad[0]
            for x in bad[1:]:
                if x == p + 1:
                    p = x
                    continue
                ranges.append((s, p)); s = p = x
            ranges.append((s, p))
            for s, e in ranges[: a.max_list]:
                print(f"    pages {s}-{e}  bytes {s * ps:#x}-{min((e + 1) * ps, limit):#x}")
            if len(ranges) > a.max_list:
                print(f"    ... {len(ranges) - a.max_list} more ranges")
            if "pre_encrypt" in cd:
                print(f"  of those, {len(bad_pre)} also mismatch the pre-encrypt hashes")

    if 5 in blobs:
        ent = blobs[5][8:]
        print("\nEntitlements (XML):")
        print(ent.decode(errors="replace"))
        if a.entitlements_out:
            open(a.entitlements_out, "wb").write(ent)
    else:
        print("\nEntitlements: none embedded")
    if 0x10000 in blobs:
        cms = blobs[0x10000][8:]
        print(f"CMS signature blob: {len(cms)} bytes{' (empty => ad-hoc style)' if len(cms) == 0 else ''}")
        if a.cms_out and cms:
            open(a.cms_out, "wb").write(cms)
    else:
        print("CMS signature blob: absent")
    return 1 if total_bad else 0


if __name__ == "__main__":
    sys.exit(main())
