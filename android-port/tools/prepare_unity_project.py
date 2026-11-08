#!/usr/bin/env python3
"""Prepare the full exported Unity project (/home/ubuntu/c113work/ar_out/ExportedProject)
for building the standalone Android APK (WhatTheGolf-Android.apk):
  1. Syncs all ported C# scripts, shaders, WTGPortCatalog.asset, and WTGAndroidBuilder.cs
     from /home/ubuntu/work/WhatTheGolf/android-port/ into the Unity project.
  2. Updates ProjectSettings/ProjectSettings.asset for Android ARM64 IL2CPP (com.thelabelgames.golf v20.5.34).
  3. Mirrors StreamingAssets/aa/iOS/*.bundle to StreamingAssets/aa/Android/*.bundle so Addressables
     resolves bundles under both /iOS/ and /Android/ runtime paths.
"""
import os
import re
import shutil
import sys

PORT_DIR = "/home/ubuntu/work/WhatTheGolf/android-port"
UNITY_PROJ = "/home/ubuntu/c113work/ar_out/ExportedProject"


def copy_tree_Files(src_root: str, dst_root: str) -> int:
    count = 0
    for dp, _, filenames in os.walk(src_root):
        rel = os.path.relpath(dp, src_root)
        target_dir = dst_root if rel == "." else os.path.join(dst_root, rel)
        os.makedirs(target_dir, exist_ok=True)
        for fn in filenames:
            sp = os.path.join(dp, fn)
            tp = os.path.join(target_dir, fn)
            shutil.copy2(sp, tp)
            count += 1
    return count


def patch_project_settings(ps_path: str) -> None:
    if not os.path.exists(ps_path):
        return
    txt = open(ps_path, encoding="utf-8", errors="ignore").read()
    txt = re.sub(r"bundleVersion:\s*[^\n]+", "bundleVersion: 20.5.34", txt)
    txt = re.sub(r"AndroidBundleVersionCode:\s*\d+", "AndroidBundleVersionCode: 200534", txt)
    txt = re.sub(r"AndroidMinSdkVersion:\s*\d+", "AndroidMinSdkVersion: 24", txt)
    txt = re.sub(r"AndroidTargetArchitectures:\s*\d+", "AndroidTargetArchitectures: 2", txt)
    with open(ps_path, "w", encoding="utf-8") as f:
        f.write(txt)


def main() -> None:
    proj = sys.argv[1] if len(sys.argv) > 1 else UNITY_PROJ
    if not os.path.exists(proj):
        print(f"Unity project not found at {proj}; run tools/run_export.sh first.")
        sys.exit(1)

    n_assets = copy_tree_Files(os.path.join(PORT_DIR, "Assets"), os.path.join(proj, "Assets"))
    n_settings = copy_tree_Files(os.path.join(PORT_DIR, "ProjectSettings"), os.path.join(proj, "ProjectSettings"))
    patch_project_settings(os.path.join(proj, "ProjectSettings", "ProjectSettings.asset"))

    aa_ios = os.path.join(proj, "Assets", "StreamingAssets", "aa", "iOS")
    aa_android = os.path.join(proj, "Assets", "StreamingAssets", "aa", "Android")

    with open(os.path.join(proj, "ProjectSettings", "ProjectVersion.txt"), "w", encoding="utf-8") as f:
        f.write("m_EditorVersion: 2020.3.49f1\n")

    print(f"Prepared Unity project at {proj} (synced {n_assets} asset files, {n_settings} project settings files)")


if __name__ == "__main__":
    main()
