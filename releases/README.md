# WHAT THE GOLF? (v20.5.34) — Compiled Android APK Release (v2 Full UI & Camera Fix)

- **Package**: `com.thelabelgames.golf` (`v20.5.34`, versionCode `200534`)
- **Architecture**: Android `arm64-v8a` IL2CPP (`OpenGLES3`, `minSdkVersion 24`, `targetSdkVersion 34`)
- **Size**: `307616102` bytes (`294 MB`)
- **SHA-256**: `332bc5b71123b191f5f5608886206965d5aa74f06a5ab47f7ce3eab77304ae66`

## Reassembling the Single APK from GitHub Parts

Because GitHub enforces a 100 MB per-file limit on normal git pushes, `WhatTheGolf-Android.apk` is stored in 90 MB parts (`WhatTheGolf-Android.apk.part00`..`part03`). Reassemble with:

```bash
cat releases/WhatTheGolf-Android.apk.part* > WhatTheGolf-Android.apk
sha256sum WhatTheGolf-Android.apk
# 332bc5b71123b191f5f5608886206965d5aa74f06a5ab47f7ce3eab77304ae66  WhatTheGolf-Android.apk
```
