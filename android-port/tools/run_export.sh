#!/usr/bin/env bash
set -euo pipefail
cd /home/ubuntu/c113work/tools/assetripper

echo "[1/3] Preparing Mono-style layout with DummyDll and StreamingAssets..."
layout="/home/ubuntu/c113work/ar_in"
rm -rf "$layout"
mkdir -p "$layout/GOLF_Data/Managed"
for f in /home/ubuntu/c112work/x/Payload/GOLF.app/Data/*; do
  case "$(basename "$f")" in
    Managed) ;;
    Raw) ln -s "$f" "$layout/GOLF_Data/StreamingAssets" ;;
    *) ln -s "$f" "$layout/GOLF_Data/$(basename "$f")" ;;
  esac
done
cp /home/ubuntu/c112work/il2cpp_out/DummyDll/*.dll "$layout/GOLF_Data/Managed/"
printf '\x7fELF' > "$layout/GOLF.x86_64"

echo "[2/3] Exporting Unity project via AssetRipper 2.0.0 with DefaultVersion=2020.3.49f1..."
port=8766
url="http://127.0.0.1:$port"
./AssetRipper.GUI.Free --headless --port "$port" --log-path "/home/ubuntu/c113work/assetripper.log" > "/home/ubuntu/c113work/assetripper.stdout" 2>&1 &
ar_pid=$!
trap 'kill $ar_pid 2>/dev/null || true' EXIT

for _ in $(seq 60); do
  curl -sf -o /dev/null "$url/" && break
  sleep 1
done

curl -sf -o /dev/null -X POST "$url/Reset"
curl -sf -o /dev/null -X POST "$url/Settings/Update" \
  -d BundledAssetsExportMode=DirectExport -d ScriptContentLevel=Level2 -d AudioExportFormat=Default \
  -d ImageExportFormat=Png -d LightmapTextureExportFormat=Image -d SpriteExportMode=Yaml \
  -d ShaderExportMode=Decompile -d TextExportMode=Parse -d ScriptLanguageVersion=AutoSafe \
  -d ScriptExportMode=Decompiled -d DefaultVersion=2020.3.49f1 -d TargetVersion=0.0.0a0 \
  -d PreferOriginalTextureExtension=true -d ExportUnreadableAssets=true
curl -sf -o /dev/null -X POST "$url/LoadFolder" --data-urlencode "Path=$layout"
out="/home/ubuntu/c113work/ar_out"
rm -rf "$out"
curl -sf -o /dev/null -X POST "$url/Export/UnityProject" --data-urlencode "Path=$out"
echo "EXPORT_DONE" > /home/ubuntu/c113work/export.status
echo "Done exporting to $out"
