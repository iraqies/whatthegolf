#!/usr/bin/env python3
"""Check every file of an .app bundle against its sealed _CodeSignature/CodeResources.

Usage: coderesources_check.py <Bundle.app or Bundle.framework> [<main executable name>]

The bundle's CodeResources is itself bound to the main executable's signature
(special slot 3, see codesig_check.py), so if every entry here matches, the
whole bundle is exactly what was signed. Reports:
  - files whose sha256 differs from the sealed "hash2"
  - sealed files that are missing (unless marked optional)
  - nested code (frameworks) whose cdhash differs from the sealed one
  - files present on disk that the seal does not cover (added after signing)
"""
import hashlib
import os
import plistlib
import re
import struct
import sys

import lief


def cdhash_sha256_20(path):
    lief.logging.disable()
    b = lief.MachO.parse(path).at(0)
    data = open(path, "rb").read()
    sig = data[b.code_signature.data_offset: b.code_signature.data_offset + b.code_signature.data_size]
    _, _, count = struct.unpack(">III", sig[:12])
    best = None
    for i in range(count):
        t, o = struct.unpack(">II", sig[12 + 8 * i: 20 + 8 * i])
        if t == 0 or 0x1000 <= t < 0x10000:
            _, ln = struct.unpack(">II", sig[o: o + 8])
            cd = sig[o: o + ln]
            if cd[37] == 2:
                best = hashlib.sha256(cd).digest()[:20]
    return best


def match_rule(rel, rules):
    """Return the highest-weight rule dict matching rel (CodeResources rules2 semantics)."""
    best, best_w = None, -1
    for pattern, spec in rules.items():
        if re.search(pattern, rel):
            spec = spec if isinstance(spec, dict) else {"_value": spec}
            w = spec.get("weight", 1)
            if w > best_w:
                best, best_w = (pattern, spec), w
    return best


def main():
    bundle = os.path.abspath(sys.argv[1])
    info = plistlib.load(open(os.path.join(bundle, "Info.plist"), "rb"))
    exe = sys.argv[2] if len(sys.argv) > 2 else info.get("CFBundleExecutable")
    cr = plistlib.load(open(os.path.join(bundle, "_CodeSignature", "CodeResources"), "rb"))
    files2, rules2 = cr.get("files2", {}), cr.get("rules2", {})
    print(f"bundle: {bundle}")
    print(f"executable: {exe}   sealed entries (files2): {len(files2)}   rules2: {len(rules2)}")

    ok = bad = missing = nested_ok = nested_bad = 0
    nested_roots = []
    for rel, spec in sorted(files2.items()):
        spec = spec if isinstance(spec, dict) else {"hash": spec}
        p = os.path.join(bundle, rel)
        if "cdhash" in spec:
            nested_roots.append(rel)
            nested_info = plistlib.load(open(os.path.join(p, "Info.plist"), "rb"))
            nexe = os.path.join(p, nested_info["CFBundleExecutable"])
            actual = cdhash_sha256_20(nexe)
            good = actual == spec["cdhash"]
            nested_ok += good
            nested_bad += not good
            print(f"  nested {rel}: sealed cdhash {spec['cdhash'].hex()} actual {actual.hex() if actual else None} "
                  f"{'OK' if good else 'MISMATCH'}")
            print(f"     requirement: {spec.get('requirement')}")
            continue
        if "symlink" in spec:
            good = os.path.islink(p) and os.readlink(p) == spec["symlink"]
            print(f"  symlink {rel}: {'OK' if good else 'MISMATCH'}")
            ok += good
            bad += not good
            continue
        if not os.path.exists(p):
            if not spec.get("optional"):
                missing += 1
                print(f"  MISSING {rel}")
            continue
        h2 = spec.get("hash2")
        actual = hashlib.sha256(open(p, "rb").read()).digest()
        if h2 is not None and actual == h2:
            ok += 1
        else:
            bad += 1
            print(f"  MISMATCH {rel}: sealed {h2.hex() if h2 else None} actual {actual.hex()}")

    unsealed = []
    for root, dirs, files in os.walk(bundle):
        for f in files:
            rel = os.path.relpath(os.path.join(root, f), bundle)
            if rel in files2 or rel == exe or rel == "_CodeSignature/CodeResources":
                continue
            if any(rel == n or rel.startswith(n + "/") for n in nested_roots):
                continue
            rule = match_rule(rel, rules2)
            if rule and rule[1].get("omit"):
                print(f"  not sealed by design (rule {rule[0]!r} omit): {rel}")
                continue
            unsealed.append(rel)
    for rel in unsealed:
        print(f"  UNSEALED FILE (present on disk, not in CodeResources): {rel}")

    print(f"summary: {ok} files match, {bad} mismatch, {missing} missing, "
          f"{nested_ok} nested OK, {nested_bad} nested mismatch, {len(unsealed)} unsealed extra files")
    return 0 if not (bad or missing or nested_bad or unsealed) else 1


if __name__ == "__main__":
    sys.exit(main())
