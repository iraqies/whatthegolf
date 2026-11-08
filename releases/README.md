# WHAT THE GOLF? (v20.5.34) — Compiled Android APK Release (v3 Full UI, Transition, Hub, Input & Resources Fix)

- **Package**: `com.thelabelgames.golf` (`v20.5.34`, versionCode `200534`)
- **Architecture**: Android `arm64-v8a` IL2CPP (`OpenGLES3`, `minSdkVersion 24`, `targetSdkVersion 34`)
- **Size**: `308824970` bytes (`295 MB`)
- **SHA-256**: `c4d77c84bb2d22fa97951a68489f80bf5e0ea9f044b9377bfc8b5b74a64f521b`

## Reassembling the Single APK from GitHub Parts

Because GitHub enforces a 100 MB per-file limit on normal git pushes, `WhatTheGolf-Android.apk` is stored in 90 MB parts (`WhatTheGolf-Android.apk.part00`..`part03`). Reassemble with:

```bash
cat releases/WhatTheGolf-Android.apk.part0* > WhatTheGolf-Android.apk
sha256sum WhatTheGolf-Android.apk
# c4d77c84bb2d22fa97951a68489f80bf5e0ea9f044b9377bfc8b5b74a64f521b  WhatTheGolf-Android.apk
```
