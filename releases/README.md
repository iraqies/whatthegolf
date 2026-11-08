# WHAT THE GOLF? (v20.5.34) — Compiled Android APK Release

- **Package**: `com.thelabelgames.golf` (`v20.5.34`, versionCode `200534`)
- **Architecture**: Android `arm64-v8a` IL2CPP (`OpenGLES3`, `minSdkVersion 24`, `targetSdkVersion 34`)
- **Size**: `302,163,681` bytes (`289 MB`)
- **SHA-256**: `6ae27eb20fabd243c17e7d97a4160d91d8f85692ca9d1dcf21c72242344dc4d0`

## Reassembling the Single APK from GitHub Parts

Because GitHub enforces a 100 MB per-file limit on normal git pushes, `WhatTheGolf-Android.apk` is stored in 90 MB parts (`WhatTheGolf-Android.apk.part00`..`part03`). Reassemble with:

```bash
cat releases/WhatTheGolf-Android.apk.part* > WhatTheGolf-Android.apk
sha256sum WhatTheGolf-Android.apk
# 6ae27eb20fabd243c17e7d97a4160d91d8f85692ca9d1dcf21c72242344dc4d0  WhatTheGolf-Android.apk
```
