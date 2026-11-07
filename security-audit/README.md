# WHAT THE GOLF? (v20.5.34) — IPA Security Audit

Result: **no backdoor found.** The IPA matches Apple's App Store signature on every code page (`GOLF`, `UnityFramework`, `GameKitWrapper`) and every data file (`181/181` sealed bundle files), and the code contains no remote-code execution, unauthorized C2, or hidden data-collection mechanisms. Full details are in [SECURITY_REPORT.md](SECURITY_REPORT.md).

Audited file: `whatthegolf-20.5.34.ipa` (`com.thelabelgames.golf`, build `261023.11511`), SHA-256 `528958eef57b35eab57a0026392b664d6c03e7820b96699ffa5050eca2f2975b`.

## Contents

| Path | What it is |
|---|---|
| `SECURITY_REPORT.md` | Cryptographic signature verification and static binary/metadata analysis report |
| `results/01-codesig-pages.txt` | CodeDirectory slot 0 (SHA-1) & slot 0x1000 (SHA-256) page-hash and pre-encrypt verification for `GOLF`, `UnityFramework`, and `GameKitWrapper` |
| `results/01-GOLF-entitlements.xml` | Extracted entitlements plist from `GOLF` |
| `results/02-cms-signature.txt` | `openssl cms -verify` results chained to Apple Root CA for all three Mach-O binaries |
| `results/03-coderesources.txt` | `_CodeSignature/CodeResources` seal verification across all 190 bundle entries |
| `results/04-zip-container.txt` | ZIP container structural and CRC integrity check (`230` entries, 0 unreferenced byte ranges) |
| `inventory/file_inventory.tsv` | Every file in `Payload/GOLF.app` with byte size and SHA-256 |
| `inventory/assemblies.tsv` | C# assemblies in `ScriptingAssemblies.json` vs. compiled IL2CPP metadata |
| `inventory/asset_bundles.tsv` | All 84 Addressables bundles in `Data/Raw/aa/iOS/` with sizes and SHA-256 hashes |
| `inventory/objc_classes.txt` | Objective-C classes in `UnityFramework` |
| `inventory/imported_symbols.txt` | Imported symbols in `UnityFramework` |
| `tools/` | Reproducible Python verification scripts (`codesig_check.py`, `cms_verify.py`, `coderesources_check.py`, `zip_container_check.py`, `il2cpp_xref.py`) |
