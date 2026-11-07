# Security Audit: WHAT THE GOLF? 20.5.34 IPA

**Verdict: no backdoor found.** The IPA (`whatthegolf-20.5.34.ipa`) is byte-for-byte the genuine build distributed by Apple through the App Store (Apple Arcade), apart from standard FairPlay decryption. Every code page of all three Mach-O binaries matches either the post-encryption or pre-encryption SHA-1 and SHA-256 hashes signed by Apple's `Apple iPhone OS Application Signing` certificate, and all 181 non-executable bundle files match their sealed `_CodeSignature/CodeResources` digests.

## 1. Sample Summary

| Field | Value |
|---|---|
| File | `whatthegolf-20.5.34.ipa` |
| Size | `202,021,743` bytes |
| SHA-256 | `528958eef57b35eab57a0026392b664d6c03e7820b96699ffa5050eca2f2975b` |
| Bundle ID | `com.thelabelgames.golf` (Team ID `YXKAU4DAAQ`) |
| Version | `20.5.34` (`CFBundleVersion` `261023.11511`), Minimum iOS `13.0`, Apple Arcade |
| Engine | Unity `2020.3.49f1`, IL2CPP ARM64 (metadata v27.1) |

## 2. Cryptographic Signature & Seal Verification

| Check | Result |
|---|---|
| Apple CMS signature (`02-cms-signature.txt`) | `openssl cms -verify` against Apple Root CA succeeds for `GOLF`, `Frameworks/UnityFramework.framework/UnityFramework`, and `Frameworks/GameKitWrapper.framework/GameKitWrapper`. |
| `GOLF` launcher (`88,736` bytes) | `17/17` code pages match signed CodeDirectory hashes (`12` post-encrypt, `5` pre-encrypt; `0` mismatches). All special slots (`Info.plist`, `Requirements`, `ResourceDir`, `Entitlements`, `DER-Entitlements`) match. |
| `UnityFramework` (`62,201,472` bytes) | `14,806/14,806` code pages match signed CodeDirectory hashes (`1,213` post-encrypt, `13,593` pre-encrypt; `0` mismatches). |
| `GameKitWrapper` (`525,328` bytes) | `121/121` code pages match signed CodeDirectory hashes (`52` post-encrypt, `69` pre-encrypt; `0` mismatches). |
| `_CodeSignature/CodeResources` (`03-coderesources.txt`) | `181/181` data and resource files match their sealed SHA-1 and SHA-256 hashes (`0` unsealed extra files). Only the two decrypted framework binaries (`UnityFramework`, `GameKitWrapper`) and the 7 stripped `SC_Info/*.sup*` FairPlay DRM files differ, as expected for a decrypted IPA. |
| ZIP container (`04-zip-container.txt`) | `230` entries, `0` prepended/appended bytes, `0` unreferenced gaps, `0` header discrepancies, all CRCs valid. |

## 3. Static Binary & IL2CPP Cross-Reference Analysis

Using `tools/il2cpp_xref.py` across all `142,790` methods and `279,979` direct/tail call edges in `UnityFramework`:

- **Network & Cloud Services**:
  - `CloudSave` and `iOSOnlineServices` use Apple iCloud CloudKit (`iCloud.com.thelabelgames.golf.cloud`) and Game Center (`com.redgamesco.arcade.GameKitWrapper`) for save synchronization and leaderboards/achievements.
  - `BetaAnalytics` / `Triband.Analytics` and `AWSSDK.Kinesis` / `AWSSDK.CognitoIdentity` are gated behind Apple Arcade analytics consent (`AskForAnalyticsDialog` / `CreateConsentPopupRequestsCommand`).
  - `dailyChallengeUrl.golf` and `PlayFab` client models are present for daily challenge leaderboard lookups.
- **No Dynamic Code Loading or Backdoors**:
  - No JIT or debugging entitlements (`get-task-allow` and `dynamic-codesigning` are absent).
  - All 84 Addressables bundles (`Data/Raw/aa/iOS/*.bundle`) contain only Unity scenes, prefabs, meshes, textures, audio clips, fonts, and ScriptableObjects — no executable code or scripts.
