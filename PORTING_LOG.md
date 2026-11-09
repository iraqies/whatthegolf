# What The Golf? — iOS IPA to Android Porting Log (`PORTING_LOG.md`)

## Project Facts
- **Original Unity Version**: `2020.3.37f1` (verified from IPA `data.unity3d` & `ProjectSettings/ProjectVersion.txt`)
- **Build Unity Version**: `2022.3.62f2` (`/opt/unity/Editor/Unity`, Linux batchmode)
- **Render Pipeline**: Built-in Render Pipeline (`m_CustomRenderPipeline: {fileID: 0}`), Gamma Color Space (`m_ActiveColorSpace: 0`)
- **Recovery Pipeline**: AssetRipper (`ExportedProject`) + Cpp2IL (`IsilDump` ARM64/ISIL disassembly & `DiffableCs` from iOS Mach-O `WTG`)
- **Target Platform**: Android (`arm64-v8a`, IL2CPP, OpenGLES3 / Vulkan, Portrait rotated mobile mode)

---

## Issue & Fix Log

### Phase 2 — Blockers (Round Completion, Save Persistence & Return-to-Lab Loop)

| ID | Issue | Root Cause (GameObject / Script:Line / Disassembly) | Fix & Files Changed | Status |
|---|---|---|---|---|
| **P2-01** | Completed rounds/doors not persisting across reloads | `SaveGame.cs:729` (`GetStringList`): MiniJSON deserializes JSON arrays as `List<object>`, so `TryGetValue<List<string>>` threw `InvalidCastException` and wiped `COMPLETED_LEVELS`, `OPEN_DOORS`, `OPEN_MAIN_DOORS`. | Fixed `SaveGame.GetStringList` to convert `IList` elements and call `PlayerPrefs.Save()`. (`Assets/Scripts/Assembly-CSharp/SaveGame.cs`) | **Done** (`9b344d40`) |
| **P2-02** | Infinite re-entry loop when returning to Lab from a completed round | 1. `OverworldGoal.OnCollisionEnter2D` (`OverworldGoal.cs:277`) did not disable `circleCollider` & `boxCollider` on hit, and `UpdatePlayerTracking` was an empty `yield break` stub instead of waiting for `PlayerOutOfRange()` (`OverworldGoal.txt` @ `0x015B8C58`).<br>2. `OverworldManager2d.ReturnToOverworld` (`OverworldManager2d.cs:614`) was a 2-line stub and never ran `ShowBallDelayed(goalHit)` (`0x01818444`) to reposition the ball to `ballStartPosition` (`GetSafeBallPosition`) after re-enabling the Lab.<br>3. `OverworldUI.ShowPlayagainDialog` (`OverworldUI.cs:154`) immediately invoked `onPlayLevelCallback` instead of opening `PlayAgainDialogContainer` and waiting for user input or cancel. | Reconstructed `OverworldGoal.OnCollisionEnter2D` + `UpdatePlayerTracking` + `PlayerOutOfRange`; reconstructed `OverworldManager2d.Goal_OnHit`, `StartGoalLevel` (multi-level `GetAllGoalLevels()` sequence), `ReturnToOverworld` (`isUsingCustomOverworldMusic`, `PlayRandomClip`, `ShowBallDelayed`); reconstructed `OverworldUI.ShowPlayagainDialog` & `SubObjectiveUIElement`; fixed `LevelManager.cs` completion callback state. (`OverworldGoal.cs`, `OverworldManager2d.cs`, `OverworldUI.cs`, `SubObjectiveUIElement.cs`, `LevelManager.cs`) | **Done** (Verified 0 C# errors) |
| **P2-03** | First Lab round (`AHoleInAOne`) & non-ball rounds not moving on shoot | `HoleShooter.cs` (`AHoleInAOne.unity` GO `76`/`77`) & `RollingCowShooter.cs` (`CatBall.unity`) started with `isKinematic = true` and had stub `OnShoot` implementations. | Reconstructed `HoleShooter`, `RollingCowShooter`, and 100+ custom `Shooter` subclasses from `IsilDump`. (`HoleShooter.cs`, `RollingCowShooter.cs`, etc.) | **Done** (`c4d675d3`) |

---

### Phase 3 — The Lab, Visuals (Shaders, Materials & Particle Effects)

| ID | Issue | Root Cause (GameObject / Material / Shader) | Fix & Files Changed | Status |
|---|---|---|---|---|
| **P3-01** | Lab door-opening effect & PC button burst render as solid black squares/circles | `Art/Models/Materials/BlackSmoke.mat` (`guid: 60c022c91d02f154cb550feacd3709b6`, used on `PlantParticlesSpawner` GO `26300` -> `Managed Particles 0` for `OverworldButton2D.openParticles`) and 46 other Particle materials (`StarParticleTrail.mat`, `Bubble.mat`, `FallLeaf.mat`, `dust particles.mat`, etc.) were exported by AssetRipper with `_Mode: 0, _SrcBlend: 1, _DstBlend: 0, _ZWrite: 1` (Opaque) instead of alpha-blended/additive particle settings. | Updating `BlackSmoke.mat`, `StarParticleTrail.mat`, and all broken opaque particle materials to proper Transparent/Particle blending (`_SrcBlend: 5, _DstBlend: 10, _ZWrite: 0`). | **In Progress** |
| **P3-02** | `Custom/GolfLambertParticles` renders particle meshes opaque (`alpha = 1.0`) | `Assets/Shader/Custom_GolfLambertParticles.shader` has `Tags { "RenderType"="Opaque" "Queue"="Geometry" }` and `return fixed4(lit * shade * atten, 1.0);` ignoring texture/vertex/tint alpha. | Rebuilding `Custom_GolfLambertParticles.shader` to respect alpha (`tex.a * _Color.a * i.color.a`) and proper blending. | **In Progress** |
| **P3-03** | `Custom/PostProcessScanlines` & `Custom/Screen Flicker` are ripped 3D Lambert stubs | `Assets/Shaders/PostProcessScanlines.shader` and `Assets/Shaders/ScreenFlicker/ScreenFlicker.shader` were replaced with generic `dot(n,l)` opaque 3D shaders during initial recovery. | Rebuilding both shaders (`PostProcessScanlines.shader` & `ScreenFlicker.shader`) with proper UV scrolling, scanline/flicker math, and transparency. | **In Progress** |
| **P3-04** | Lab room lights staying dark after intro flicker | `IntroAnimation.cs` left `DarknessRenderer` (`DarknessSprite` GO `36189`, `Sprites-Multiply.mat`) active without completing the `DarknessDark` -> `DarknessLight` tween and disabling `DarknessRenderer`. | Reconstructed full `IntroAnimation.IntroRoutine` light flicker sequence from `IntroAnimation+<IntroRoutine>d__28.txt`. (`IntroAnimation.cs`) | **Done** (`c4d675d3`) |

---

### Phase 4 — The Lab, Audio

| ID | Issue | Root Cause (GameObject / Script:Line) | Fix & Files Changed | Status |
|---|---|---|---|---|
| **P4-01** | Lab door opening has no sound or rumble | 1. `AudioEventAsset.cs` used `Time.unscaledTime` cooldown state that blocked playback.<br>2. `OverworldButton2D.CheckOpen` checked `sfxOpen` (empty) without falling back to `sfxOnOpen` (`b65b91b61fa732c44b0272ea94291659`).<br>3. `AudioEventListenerBase.Awake()` was an empty stub so `IAudioEvent` transmitters never subscribed their `PlayClipOnAudioEvent` components. | Fixed `AudioEventAsset.cs`, `OverworldButton2D.cs`, `OverworldDoor.cs`, and `AudioEventListenerBase.cs`. Auditing remaining Lab interactive objects. | **Done** (`9b344d40`), full Lab audit in Phase 4 |
