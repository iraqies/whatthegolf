# WHAT THE GOLF? (v20.5.34) — Compiled Android APK Release (v4 Shaders, Tutorial Overlays, Splash Screen & Full Audio Engine Fix)

- **Package**: `com.thelabelgames.golf` (`v20.5.34`, versionCode `200534`)
- **Architecture**: Android `arm64-v8a` IL2CPP (`OpenGLES3`, `minSdkVersion 24`, `targetSdkVersion 34`)
- **Size**: `309547010` bytes (`296 MB`)
- **SHA-256**: `42c9a72c85b1486e08754363ba544d991cca71a975ddd1e36e641e24b036a01f`

## Reassembling the Single APK from GitHub Parts

Because GitHub enforces a 100 MB per-file limit on normal git pushes, `WhatTheGolf-Android.apk` is stored in 90 MB parts (`WhatTheGolf-Android.apk.part00`..`part03`). Reassemble with:

```bash
cat releases/WhatTheGolf-Android.apk.part0* > WhatTheGolf-Android.apk
sha256sum WhatTheGolf-Android.apk
# 42c9a72c85b1486e08754363ba544d991cca71a975ddd1e36e641e24b036a01f  WhatTheGolf-Android.apk
```
