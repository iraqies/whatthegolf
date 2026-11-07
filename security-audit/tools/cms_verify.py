#!/usr/bin/env python3
"""Verify the CMS (PKCS#7) signature embedded in a Mach-O code signature.

Usage: cms_verify.py <macho> <AppleIncRootCertificate.pem>

The CMS blob signs the primary CodeDirectory. Apple also adds two signed
attributes that bind every CodeDirectory (including the SHA-256 one iOS
enforces): OID 1.2.840.113635.100.9.1 (a plist with truncated "cdhashes") and
OID 1.2.840.113635.100.9.2 (full hashes with their algorithm). This script:
  1. verifies the CMS signature over CodeDirectory slot 0 with openssl, chained
     to the Apple root certificate you pass in (PEM);
  2. checks both attributes list the hash of every CodeDirectory in the binary;
  3. prints the signer certificate chain and signing time.
"""
import hashlib
import plistlib
import struct
import subprocess
import sys
import tempfile

import lief
from asn1crypto import cms as acms
from asn1crypto import core


def main():
    macho, root = sys.argv[1], sys.argv[2]
    lief.logging.disable()
    b = lief.MachO.parse(macho).at(0)
    data = open(macho, "rb").read()
    sig = data[b.code_signature.data_offset: b.code_signature.data_offset + b.code_signature.data_size]
    _, _, count = struct.unpack(">III", sig[:12])
    blobs = {}
    for i in range(count):
        t, o = struct.unpack(">II", sig[12 + 8 * i: 20 + 8 * i])
        _, ln = struct.unpack(">II", sig[o: o + 8])
        blobs[t] = sig[o: o + ln]
    cds = {t: v for t, v in blobs.items() if t == 0 or 0x1000 <= t < 0x10000}
    cms = blobs[0x10000][8:]

    with tempfile.TemporaryDirectory() as td:
        cd_path, cms_path = f"{td}/cd.bin", f"{td}/cms.der"
        open(cd_path, "wb").write(cds[0])
        open(cms_path, "wb").write(cms)
        r = subprocess.run(["openssl", "cms", "-verify", "-inform", "DER", "-in", cms_path,
                            "-content", cd_path, "-binary", "-CAfile", root, "-purpose", "any",
                            "-out", "/dev/null"], capture_output=True, text=True)
    print(f"{macho}: openssl cms -verify (content = CodeDirectory slot 0, CA = Apple Root CA) -> "
          f"{'OK' if r.returncode == 0 else 'FAILED'}: {r.stderr.strip()}")

    sd = acms.ContentInfo.load(cms)["content"]
    for cert in sd["certificates"]:
        c = cert.chosen
        print(f"  cert: {c.subject.human_friendly}  |  issuer: {c.issuer.human_friendly}  |  "
              f"valid {c['tbs_certificate']['validity']['not_before'].native:%Y-%m-%d} .. "
              f"{c['tbs_certificate']['validity']['not_after'].native:%Y-%m-%d}")
    signer = sd["signer_infos"][0]
    plist_hashes, full_hashes = [], []
    for attr in signer["signed_attrs"]:
        oid = attr["type"].dotted
        if oid == "1.2.840.113549.1.9.5":
            print("  signingTime:", attr["values"][0].native)
        elif oid == "1.2.840.113635.100.9.1":
            raw = core.OctetString.load(attr["values"][0].dump()).native
            plist_hashes = [h.hex() for h in plistlib.loads(raw).get("cdhashes", [])]
        elif oid == "1.2.840.113635.100.9.2":
            for v in attr["values"]:
                seq = core.Sequence.load(v.dump())
                full_hashes.append(core.OctetString.load(seq[1].dump()).native.hex())
    print("  signed cdhashes plist (100.9.1):", plist_hashes)
    print("  signed full cdhashes (100.9.2):", full_hashes)

    ok_all = r.returncode == 0
    for t, cd in sorted(cds.items()):
        hash_type = cd[37]
        full = (hashlib.sha1(cd) if hash_type == 1 else hashlib.sha256(cd)).hexdigest()
        listed = full[:40] in plist_hashes and full in full_hashes
        ok_all &= listed
        print(f"  CodeDirectory {t:#x} ({'sha1' if hash_type == 1 else 'sha256'}) cdhash {full} signed: {listed}")
    print("  RESULT:", "signature valid, every CodeDirectory is signed by Apple" if ok_all else "PROBLEM")
    return 0 if ok_all else 1


if __name__ == "__main__":
    sys.exit(main())
