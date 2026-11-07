#!/usr/bin/env python3
"""Look for tricks in the .ipa zip container itself.

Usage: zip_container_check.py <file.ipa>

Checks: bytes before the first local header or after the end-of-central-
directory record, archive comment, duplicate entry names (different unzip
tools pick different copies), path traversal / absolute paths, symlink
entries, entries outside Payload/<App>.app, and disagreement between each
entry's local header and its central-directory record (name, sizes, CRC).
"""
import collections
import struct
import sys
import zipfile


def main():
    path = sys.argv[1]
    raw = open(path, "rb").read()
    zf = zipfile.ZipFile(path)
    infos = zf.infolist()
    problems = 0

    first_local = raw.find(b"PK\x03\x04")
    eocd = raw.rfind(b"PK\x05\x06")
    comment_len = struct.unpack("<H", raw[eocd + 20: eocd + 22])[0]
    tail = len(raw) - (eocd + 22 + comment_len)
    print(f"size {len(raw)}  entries {len(infos)}  first local header @ {first_local}  EOCD @ {eocd}")
    print(f"prepended bytes: {first_local}   appended bytes after EOCD+comment: {tail}   comment length: {comment_len}")
    problems += bool(first_local) + bool(tail) + bool(comment_len)

    names = collections.Counter(i.filename for i in infos)
    dups = [n for n, c in names.items() if c > 1]
    print(f"duplicate names: {dups or 'none'}")
    problems += len(dups)

    apps = collections.Counter(i.filename.split("/")[1] for i in infos if i.filename.startswith("Payload/") and i.filename.count("/") >= 1 and i.filename.split("/")[1])
    print(f"top-level items under Payload/: {dict(apps)}")
    outside = [i.filename for i in infos if not i.filename.startswith("Payload/")]
    print(f"entries outside Payload/: {outside or 'none'}")
    problems += len(outside)

    bad_paths = [i.filename for i in infos if i.filename.startswith("/") or ".." in i.filename.split("/") or "\\" in i.filename]
    print(f"absolute / traversal / backslash paths: {bad_paths or 'none'}")
    problems += len(bad_paths)

    symlinks = [i.filename for i in infos if (i.external_attr >> 16) & 0o170000 == 0o120000]
    print(f"symlink entries: {symlinks or 'none'}")
    problems += len(symlinks)

    mismatched = []
    for i in infos:
        off = i.header_offset
        sig, _ver, flags, method, _t, _d, crc, csize, usize, nlen, xlen = struct.unpack("<IHHHHHIIIHH", raw[off: off + 30])
        lname = raw[off + 30: off + 30 + nlen].decode("utf-8", "replace")
        if sig != 0x04034B50 or lname != i.filename or method != i.compress_type:
            mismatched.append((i.filename, "header/name/method"))
            continue
        if not flags & 0x8 and (crc != i.CRC or csize != i.compress_size or usize != i.file_size):
            mismatched.append((i.filename, "crc/size"))
    print(f"local vs central header disagreements: {mismatched or 'none'}")
    problems += len(mismatched)

    bad_crc = zf.testzip()
    print(f"CRC test of every entry: {'all OK' if bad_crc is None else 'first bad: ' + bad_crc}")
    problems += bad_crc is not None

    covered = sorted((i.header_offset, i.header_offset + 30 + len(i.filename.encode()) + len(i.extra) + i.compress_size) for i in infos)
    gaps = []
    prev_end = covered[0][0]
    for s, e in covered:
        if s > prev_end + 16:
            gaps.append((prev_end, s))
        prev_end = max(prev_end, e)
    cd_start = struct.unpack("<I", raw[eocd + 16: eocd + 20])[0]
    if cd_start > prev_end + 16:
        gaps.append((prev_end, cd_start))
    print(f"unreferenced byte ranges between entries: {gaps or 'none'}")
    problems += len(gaps)

    print("RESULT:", "container is clean" if not problems else f"{problems} issue(s)")
    return 1 if problems else 0


if __name__ == "__main__":
    sys.exit(main())
