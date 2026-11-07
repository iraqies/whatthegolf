#!/usr/bin/env python3
"""Generate Assets/Resources/WTGPortCatalog.asset and ProjectSettings/EditorBuildSettings.asset
linking all 17 ContentPack episodes, all 169 LevelData assets, and all 336 exported .unity scenes
so every Overworld and Level scene loads natively on Android via SceneManager / Addressables.
"""
import glob
import os
import re

EXPORT_PROJ = "/home/ubuntu/c113work/ar_out/ExportedProject"
PORT_PROJ = "/home/ubuntu/work/WhatTheGolf/android-port"

CATALOG_SCRIPT_GUID = "d1a7b207000040008000000000000001"
CATALOG_ASSET_GUID = "d1a7b207000040008000000000000004"


def read_guid(meta_path: str) -> str:
    if not os.path.exists(meta_path):
        return ""
    txt = open(meta_path, encoding="utf-8", errors="ignore").read()
    m = re.search(r"guid:\s*([0-9a-f]{32})", txt)
    return m.group(1) if m else ""


def main() -> None:
    assets_root = os.path.join(EXPORT_PROJ, "Assets")
    guid_to_path = {}
    for mp in glob.glob(os.path.join(assets_root, "**", "*.meta"), recursive=True):
        p = mp[:-5]
        if os.path.isdir(p):
            continue
        g = read_guid(mp)
        if g:
            guid_to_path[g] = p

    # 1. Collect all .unity scenes (excluding directories like zxing.unity)
    scenes = []
    for sp in sorted(glob.glob(os.path.join(assets_root, "**", "*.unity"), recursive=True)):
        if os.path.isdir(sp):
            continue
        rel = os.path.relpath(sp, EXPORT_PROJ).replace("\\", "/")
        g = read_guid(sp + ".meta")
        name = os.path.splitext(os.path.basename(sp))[0]
        scenes.append((rel, g, name))

    # Order scenes: _Start.unity first, Loading.unity second, Overworlds next, then all level scenes
    def scene_sort_key(item):
        rel, g, name = item
        if rel == "Assets/Scenes/_Start.unity":
            return (0, rel)
        if rel == "Assets/Scenes/Loading.unity":
            return (1, rel)
        if "Overworld" in name or "overworld" in name:
            return (2, rel)
        return (3, rel)

    scenes.sort(key=scene_sort_key)

    # Write EditorBuildSettings.asset to both EXPORT_PROJ and PORT_PROJ
    ebs_lines = [
        "%YAML 1.1",
        "%TAG !u! tag:unity3d.com,2011:",
        "--- !u!1045 &1",
        "EditorBuildSettings:",
        "  serializedVersion: 2",
        "  m_ObjectHideFlags: 0",
        "  m_Scenes:",
    ]
    for rel, g, _ in scenes:
        ebs_lines.append("  - enabled: 1")
        ebs_lines.append(f"    path: {rel}")
        ebs_lines.append(f"    guid: {g}")
    ebs_lines.append("  m_configObjects: {}")
    ebs_text = "\n".join(ebs_lines) + "\n"

    for proj in (EXPORT_PROJ, PORT_PROJ):
        ebs_path = os.path.join(proj, "ProjectSettings", "EditorBuildSettings.asset")
        with open(ebs_path, "w", encoding="utf-8") as f:
            f.write(ebs_text)

    # 2. Collect all LevelData assets
    level_guids = []
    for lp in sorted(glob.glob(os.path.join(assets_root, "LevelData", "**", "*.asset"), recursive=True)):
        if "Containers" in lp.split(os.sep):
            continue
        txt = open(lp, encoding="utf-8", errors="ignore").read(1024)
        if "f47705c09b44ee09bc62d5a3d8a1d0cf" in txt:
            g = read_guid(lp + ".meta")
            if g:
                level_guids.append(g)

    # 3. Parse RuntimeStoreData and ContentPacks
    rsd_path = os.path.join(assets_root, "Resources", "RuntimeStoreData.asset")
    rsd_guid = read_guid(rsd_path + ".meta")
    ps_path = os.path.join(assets_root, "Resources", "settings", "PlatformSettings.asset")
    ps_guid = read_guid(ps_path + ".meta")
    sa_path = os.path.join(assets_root, "Resources", "ShootArrow.prefab")
    sa_guid = read_guid(sa_path + ".meta")

    rsd_txt = open(rsd_path, encoding="utf-8", errors="ignore").read()
    pack_guids = re.findall(r"pack:\s*\{fileID:\s*\d+,\s*guid:\s*([0-9a-f]{32})", rsd_txt)

    episodes_yaml = []
    for pg in pack_guids:
        pp = guid_to_path.get(pg)
        if not pp or not os.path.exists(pp):
            continue
        ptxt = open(pp, encoding="utf-8", errors="ignore").read()
        m_id = re.search(r"contentPackID:\s*([^\n]*)", ptxt)
        pack_id = m_id.group(1).strip() if m_id else ""
        if pack_id == "CP_SOON_FAKE":
            continue
        m_name = re.search(r"m_Name:\s*([^\n]*)", ptxt)
        title = m_name.group(1).strip() if m_name else pack_id
        m_ow = re.search(r"overworldSceneReference:.*?sceneName:\s*([^\n]*)", ptxt, re.S)
        ow_scene = m_ow.group(1).strip() if m_ow else ""

        # Collect levels from mainContainer / onboardingContainer
        ep_levels = []
        for cm in re.finditer(r"(?:mainContainer|onboardingContainer):\s*\{fileID:\s*11400000,\s*guid:\s*([0-9a-f]{32})", ptxt):
            cg = cm.group(1)
            cp = guid_to_path.get(cg)
            if cp and os.path.exists(cp):
                ctxt = open(cp, encoding="utf-8", errors="ignore").read()
                for lg in re.findall(r"guid:\s*([0-9a-f]{32})", ctxt):
                    lp = guid_to_path.get(lg, "")
                    if lp.endswith(".asset") and "/LevelData/" in lp and "/Containers/" not in lp:
                        if lg not in ep_levels:
                            ep_levels.append(lg)

        episodes_yaml.append((pack_id, title, ow_scene, pg, ep_levels))

    cat_lines = [
        "%YAML 1.1",
        "%TAG !u! tag:unity3d.com,2011:",
        "--- !u!114 &11400000",
        "MonoBehaviour:",
        "  m_ObjectHideFlags: 0",
        "  m_CorrespondingSourceObject: {fileID: 0}",
        "  m_PrefabInstance: {fileID: 0}",
        "  m_PrefabAsset: {fileID: 0}",
        "  m_GameObject: {fileID: 0}",
        "  m_Enabled: 1",
        "  m_EditorHideFlags: 0",
        f"  m_Script: {{fileID: 11500000, guid: {CATALOG_SCRIPT_GUID}, type: 3}}",
        "  m_Name: WTGPortCatalog",
        "  m_EditorClassIdentifier: ",
        f"  storeData: {{fileID: 11400000, guid: {rsd_guid}, type: 2}}",
        f"  platformSettings: {{fileID: 11400000, guid: {ps_guid}, type: 2}}",
        f"  defaultShootArrow: {{fileID: 11400000, guid: {sa_guid}, type: 3}}",
        "  episodes:",
    ]

    for pack_id, title, ow_scene, pg, ep_levels in episodes_yaml:
        cat_lines.append(f"  - packId: {pack_id}")
        cat_lines.append(f"    title: {title}")
        cat_lines.append(f"    overworldScene: {ow_scene}")
        cat_lines.append(f"    pack: {{fileID: 11400000, guid: {pg}, type: 2}}")
        if ep_levels:
            cat_lines.append("    levels:")
            for lg in ep_levels:
                cat_lines.append(f"    - {{fileID: 11400000, guid: {lg}, type: 2}}")
        else:
            cat_lines.append("    levels: []")

    cat_lines.append("  allLevels:")
    for lg in level_guids:
        cat_lines.append(f"  - {{fileID: 11400000, guid: {lg}, type: 2}}")

    cat_lines.append("  allSceneNames:")
    for _, _, sname in scenes:
        cat_lines.append(f"  - {sname}")

    cat_text = "\n".join(cat_lines) + "\n"
    cat_meta = f"""fileFormatVersion: 2
guid: {CATALOG_ASSET_GUID}
NativeFormatImporter:
  externalObjects: {{}}
  mainObjectFileID: 11400000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
"""

    for proj in (EXPORT_PROJ, PORT_PROJ):
        res_dir = os.path.join(proj, "Assets", "Resources")
        os.makedirs(res_dir, exist_ok=True)
        cat_path = os.path.join(res_dir, "WTGPortCatalog.asset")
        with open(cat_path, "w", encoding="utf-8") as f:
            f.write(cat_text)
        with open(cat_path + ".meta", "w", encoding="utf-8") as f:
            f.write(cat_meta)

    print(f"Generated WTGPortCatalog.asset ({len(episodes_yaml)} episodes, {len(level_guids)} LevelData assets, {len(scenes)} scenes) and EditorBuildSettings.asset")


if __name__ == "__main__":
    main()
