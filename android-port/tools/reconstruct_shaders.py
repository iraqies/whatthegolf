#!/usr/bin/env python3
"""Reconstruct all DummyShaderTextExporter shaders in WHAT THE GOLF?'s Unity project
into working OpenGLES3 / Vulkan / Metal CGPROGRAM shaders while preserving exact Shader names,
Properties blocks, and .shader.meta GUIDs.
"""
import glob
import os
import re
import shutil
import sys

PORT_ASSETS = "/home/ubuntu/work/WhatTheGolf/android-port/Assets"
CC_SHADER_DIR = "/home/ubuntu/cc-analysis/audit-repo/android-port/Assets/shaders"


def copy_tmpro_cginc(target_dir: str) -> None:
    os.makedirs(target_dir, exist_ok=True)
    for fn in ("TMPro.cginc", "TMPro_Mobile.cginc", "TMPro_Properties.cginc", "TMPro_Surface.cginc"):
        src = os.path.join(CC_SHADER_DIR, fn)
        dst = os.path.join(target_dir, fn)
        if os.path.exists(src):
            shutil.copy2(src, dst)


def make_tmp_shader(shader_name: str, rel_path: str) -> str:
    low = (shader_name + " " + rel_path).lower()
    if "sprite" in low:
        src_fn = "tmp_sprite.shader"
    elif "bitmap" in low:
        src_fn = "tmp_bitmap-mobile.shader" if "mobile" in low else "tmp_bitmap.shader"
    elif "surface" in low:
        src_fn = "tmp_sdf-surface-mobile.shader" if "mobile" in low else "tmp_sdf-surface.shader"
    elif "masking" in low:
        src_fn = "tmp_sdf-mobile masking.shader"
    elif "overlay" in low:
        src_fn = "tmp_sdf-mobile overlay.shader" if "mobile" in low else "tmp_sdf overlay.shader"
    else:
        src_fn = "tmp_sdf-mobile.shader" if "mobile" in low else "tmp_sdf.shader"

    base = open(os.path.join(CC_SHADER_DIR, src_fn), encoding="utf-8").read()
    base = re.sub(r'^Shader\s+"[^"]+"', f'Shader "{shader_name}"', base, count=1)
    return base


def build_cg_shader(shader_name: str, props_block: str, rel_path: str) -> str:
    low = (shader_name + " " + rel_path).lower()

    if shader_name.startswith("TextMeshPro/"):
        return make_tmp_shader(shader_name, rel_path)

    # 1. Invisible / hidden picker shaders
    if shader_name == "Custom/Invisible" or shader_name.startswith("Hidden/ProBuilder/"):
        return f'''Shader "{shader_name}" {{
\tProperties {{
{props_block}
\t}}
\tSubShader {{
\t\tTags {{ "Queue"="Transparent" "RenderType"="Transparent" }}
\t\tPass {{
\t\t\tColorMask 0
\t\t\tZWrite Off
\t\t\tCGPROGRAM
\t\t\t#pragma vertex vert
\t\t\t#pragma fragment frag
\t\t\t#include "UnityCG.cginc"
\t\t\tfloat4 vert(float4 v : POSITION) : SV_POSITION {{ return UnityObjectToClipPos(v); }}
\t\t\tfixed4 frag() : SV_Target {{ return 0; }}
\t\t\tENDCG
\t\t}}
\t}}
}}
'''

    # 2. Stencil / depth mask shader
    if shader_name == "Masked/Mask":
        return f'''Shader "{shader_name}" {{
\tProperties {{
{props_block}
\t}}
\tSubShader {{
\t\tTags {{ "Queue"="Geometry-10" "RenderType"="Opaque" }}
\t\tColorMask 0
\t\tZWrite On
\t\tPass {{
\t\t\tCGPROGRAM
\t\t\t#pragma vertex vert
\t\t\t#pragma fragment frag
\t\t\t#include "UnityCG.cginc"
\t\t\tfloat4 vert(float4 v : POSITION) : SV_POSITION {{ return UnityObjectToClipPos(v); }}
\t\t\tfixed4 frag() : SV_Target {{ return 0; }}
\t\t\tENDCG
\t\t}}
\t}}
}}
'''

    # 3. Screen-space post-processing shaders (CameraFilterPack, SphericalGrayscale, SWS/Blur, FMVTexture)
    if shader_name.startswith("CameraFilterPack/") or shader_name in ("Custom/SphericalGrayscale", "Hidden/SWS/Blur", "FMVTexture"):
        extra_decls = ""
        frag_body = "fixed4 col = tex2D(_MainTex, i.uv);\n\t\t\t\treturn col;"
        if "grayscale" in low and shader_name != "Custom/SphericalGrayscale":
            frag_body = "fixed4 col = tex2D(_MainTex, i.uv);\n\t\t\t\tfloat l = dot(col.rgb, float3(0.299, 0.587, 0.114));\n\t\t\t\treturn fixed4(l, l, l, col.a);"
        elif "sepia" in low:
            frag_body = "fixed4 col = tex2D(_MainTex, i.uv);\n\t\t\t\tfloat3 s = float3(dot(col.rgb, float3(0.393, 0.769, 0.189)), dot(col.rgb, float3(0.349, 0.686, 0.168)), dot(col.rgb, float3(0.272, 0.534, 0.131)));\n\t\t\t\treturn fixed4(saturate(s), col.a);"
        elif "vhs_rewind" in low:
            extra_decls = "float _TimeX;"
            frag_body = "float2 uv = i.uv;\n\t\t\t\tuv.x += sin(uv.y * 40.0 + _TimeX * 15.0) * 0.003;\n\t\t\t\tfixed4 col = tex2D(_MainTex, uv);\n\t\t\t\treturn col;"
        elif shader_name == "Custom/SphericalGrayscale":
            extra_decls = "float _Intensity;"
            frag_body = "fixed4 col = tex2D(_MainTex, i.uv);\n\t\t\t\tfloat l = dot(col.rgb, float3(0.299, 0.587, 0.114));\n\t\t\t\tcol.rgb = lerp(col.rgb, float3(l, l, l), saturate(_Intensity));\n\t\t\t\treturn col;"
        elif shader_name == "FMVTexture":
            extra_decls = "sampler2D _ChromaTex;"
            frag_body = "float y = tex2D(_MainTex, i.uv).r;\n\t\t\t\tfloat2 uv = tex2D(_ChromaTex, i.uv).rg - 0.5;\n\t\t\t\tfloat3 rgb = float3(y + 1.402 * uv.y, y - 0.344136 * uv.x - 0.714136 * uv.y, y + 1.772 * uv.x);\n\t\t\t\treturn fixed4(saturate(rgb), 1.0);"

        return f'''Shader "{shader_name}" {{
\tProperties {{
{props_block}
\t}}
\tSubShader {{
\t\tCull Off ZWrite Off ZTest Always
\t\tPass {{
\t\t\tCGPROGRAM
\t\t\t#pragma vertex vert_img
\t\t\t#pragma fragment frag
\t\t\t#include "UnityCG.cginc"
\t\t\tsampler2D _MainTex;
\t\t\t{extra_decls}
\t\t\tfixed4 frag(v2f_img i) : SV_Target {{
\t\t\t\t{frag_body}
\t\t\t}}
\t\t\tENDCG
\t\t}}
\t}}
}}
'''

    # 4. Triband/GolfTerrain procedural terrain shader
    if shader_name == "Triband/GolfTerrain":
        return f'''Shader "{shader_name}" {{
\tProperties {{
{props_block}
\t}}
\tSubShader {{
\t\tTags {{ "RenderType"="Opaque" "Queue"="Geometry" }}
\t\tLOD 200
\t\tPass {{
\t\t\tTags {{ "LightMode"="ForwardBase" }}
\t\t\tCGPROGRAM
\t\t\t#pragma vertex vert
\t\t\t#pragma fragment frag
\t\t\t#include "UnityCG.cginc"

\t\t\tfloat4 _SurfaceColor;
\t\t\tfloat4 _BevelColor;
\t\t\tfloat4 _SkirtColorA;
\t\t\tfloat4 _SkirtColorB;
\t\t\tfloat _SkirtBandWidth;
\t\t\tfloat4 _ShadowColor;

\t\t\tstruct appdata {{
\t\t\t\tfloat4 vertex : POSITION;
\t\t\t\tfloat3 normal : NORMAL;
\t\t\t\tfloat4 color : COLOR;
\t\t\t}};

\t\t\tstruct v2f {{
\t\t\t\tfloat4 pos : SV_POSITION;
\t\t\t\tfloat3 wnorm : TEXCOORD0;
\t\t\t\tfloat3 wpos : TEXCOORD1;
\t\t\t\tfloat4 color : COLOR;
\t\t\t}};

\t\t\tv2f vert(appdata v) {{
\t\t\t\tv2f o;
\t\t\t\to.pos = UnityObjectToClipPos(v.vertex);
\t\t\t\to.wnorm = UnityObjectToWorldNormal(v.normal);
\t\t\t\to.wpos = mul(unity_ObjectToWorld, v.vertex).xyz;
\t\t\t\to.color = v.color;
\t\t\t\treturn o;
\t\t\t}}

\t\t\tfixed4 frag(v2f i) : SV_Target {{
\t\t\t\tfloat3 n = normalize(i.wnorm);
\t\t\t\tfloat up = saturate(n.y);
\t\t\t\tfloat band = frac(i.wpos.y / max(_SkirtBandWidth, 0.1)) > 0.5 ? 1.0 : 0.0;
\t\t\t\tfloat4 skirt = lerp(_SkirtColorA, _SkirtColorB, band);
\t\t\t\tfloat4 baseCol = up > 0.85 ? _SurfaceColor : (up > 0.35 ? _BevelColor : skirt);
\t\t\t\tfloat3 l = normalize(_WorldSpaceLightPos0.xyz + float3(0.3, 0.8, -0.4));
\t\t\t\tfloat ndotl = saturate(dot(n, l));
\t\t\t\tfloat3 rgb = lerp(baseCol.rgb * (1.0 - _ShadowColor.a * 0.35) + _ShadowColor.rgb * 0.2, baseCol.rgb, 0.55 + 0.45 * ndotl);
\t\t\t\treturn fixed4(rgb, 1.0);
\t\t\t}}
\t\t\tENDCG
\t\t}}
\t}}
\tFallBack "Diffuse"
}}
'''

    # 5. Custom/GolfLambert family (the primary toon-lambert shader across all levels)
    if shader_name.startswith("Custom/GolfLambert"):
        has_tex = "_MainTex" in props_block
        has_wave = "_WaveSize" in props_block
        is_2d = "2D" in shader_name
        is_particles = "Particles" in shader_name
        is_double = "Double-sided" in shader_name or is_2d or is_particles
        use_vcol = "Vertex Color" in shader_name or is_particles or is_2d

        cull_str = "Cull Off" if is_double else "Cull Back"
        tex_decl = "sampler2D _MainTex; float4 _MainTex_ST;" if has_tex else ""
        wave_decl = "float _WaveSize; float _WaveSpeed;" if has_wave else ""
        vert_mod = "v.vertex.y += sin(_Time.y * _WaveSpeed + v.vertex.x * 0.5 + v.vertex.z * 0.5) * _WaveSize * 0.08;" if has_wave else ""
        uv_calc = "o.uv = TRANSFORM_TEX(v.uv, _MainTex);" if has_tex else "o.uv = v.uv;"
        tex_mul = "albedo *= tex2D(_MainTex, i.uv);" if has_tex else ""
        vcol_mul = "albedo *= i.color;" if use_vcol else ""

        return f'''Shader "{shader_name}" {{
\tProperties {{
{props_block}
\t}}
\tSubShader {{
\t\tTags {{ "RenderType"="Opaque" "Queue"="Geometry" }}
\t\tLOD 200
\t\t{cull_str}
\t\tPass {{
\t\t\tTags {{ "LightMode"="ForwardBase" }}
\t\t\tCGPROGRAM
\t\t\t#pragma vertex vert
\t\t\t#pragma fragment frag
\t\t\t#include "UnityCG.cginc"

\t\t\tfloat4 _Color;
\t\t\tfloat4 _HighlightColor;
\t\t\tfloat4 _ShadowColor;
\t\t\tfloat _HighlightAmount;
\t\t\tfloat _HighlightAngle;
\t\t\t{tex_decl}
\t\t\t{wave_decl}

\t\t\tstruct appdata {{
\t\t\t\tfloat4 vertex : POSITION;
\t\t\t\tfloat3 normal : NORMAL;
\t\t\t\tfloat2 uv : TEXCOORD0;
\t\t\t\tfloat4 color : COLOR;
\t\t\t}};

\t\t\tstruct v2f {{
\t\t\t\tfloat4 pos : SV_POSITION;
\t\t\t\tfloat3 wnorm : TEXCOORD0;
\t\t\t\tfloat2 uv : TEXCOORD1;
\t\t\t\tfloat4 color : COLOR;
\t\t\t}};

\t\t\tv2f vert(appdata v) {{
\t\t\t\tv2f o;
\t\t\t\t{vert_mod}
\t\t\t\to.pos = UnityObjectToClipPos(v.vertex);
\t\t\t\to.wnorm = UnityObjectToWorldNormal(v.normal);
\t\t\t\t{uv_calc}
\t\t\t\to.color = v.color;
\t\t\t\treturn o;
\t\t\t}}

\t\t\tfixed4 frag(v2f i) : SV_Target {{
\t\t\t\tfloat4 albedo = _Color;
\t\t\t\t{vcol_mul}
\t\t\t\t{tex_mul}
\t\t\t\tfloat3 n = normalize(i.wnorm);
\t\t\t\tfloat3 l = any(_WorldSpaceLightPos0.xyz) ? normalize(_WorldSpaceLightPos0.xyz) : normalize(float3(0.35, 0.85, -0.4));
\t\t\t\tfloat ndotl = dot(n, l) * 0.5 + 0.5;
\t\t\t\tfloat3 shaded = lerp(albedo.rgb * (1.0 - saturate(_ShadowColor.a) * 0.45) + _ShadowColor.rgb * 0.25, albedo.rgb, saturate(ndotl));
\t\t\t\tfloat hl = smoothstep(1.0 - max(_HighlightAngle, 0.05), 1.0, ndotl) * _HighlightAmount * 0.25;
\t\t\t\tshaded = saturate(shaded + _HighlightColor.rgb * hl);
\t\t\t\treturn fixed4(shaded, albedo.a);
\t\t\t}}
\t\t\tENDCG
\t\t}}
\t}}
\tFallBack "Diffuse"
}}
'''

    # 6. Water / GoopSea shaders
    if shader_name in ("WhatTheGolf/GoopSea", "StylizedWater/Mobile", "Custom/SurfaceDepthTextureColorized"):
        color_prop = "_WaterColor" if "_WaterColor" in props_block else "_Color"
        color2_prop = "_WaterColor2" if "_WaterColor2" in props_block else ("_WaterShallowColor" if "_WaterShallowColor" in props_block else "_BlendColor")
        return f'''Shader "{shader_name}" {{
\tProperties {{
{props_block}
\t}}
\tSubShader {{
\t\tTags {{ "RenderType"="Opaque" "Queue"="Geometry" }}
\t\tLOD 200
\t\tPass {{
\t\t\tCGPROGRAM
\t\t\t#pragma vertex vert
\t\t\t#pragma fragment frag
\t\t\t#include "UnityCG.cginc"

\t\t\tfloat4 {color_prop};
\t\t\tfloat4 {color2_prop};

\t\t\tstruct appdata {{
\t\t\t\tfloat4 vertex : POSITION;
\t\t\t\tfloat2 uv : TEXCOORD0;
\t\t\t}};

\t\t\tstruct v2f {{
\t\t\t\tfloat4 pos : SV_POSITION;
\t\t\t\tfloat3 wpos : TEXCOORD0;
\t\t\t}};

\t\t\tv2f vert(appdata v) {{
\t\t\t\tv2f o;
\t\t\t\to.pos = UnityObjectToClipPos(v.vertex);
\t\t\t\to.wpos = mul(unity_ObjectToWorld, v.vertex).xyz;
\t\t\t\treturn o;
\t\t\t}}

\t\t\tfixed4 frag(v2f i) : SV_Target {{
\t\t\t\tfloat wave = sin(i.wpos.x * 0.6 + _Time.y * 1.5) * cos(i.wpos.z * 0.6 + _Time.y * 1.2) * 0.5 + 0.5;
\t\t\t\tfloat3 rgb = lerp({color_prop}.rgb, {color2_prop}.rgb, wave * 0.35);
\t\t\t\treturn fixed4(rgb, 1.0);
\t\t\t}}
\t\t\tENDCG
\t\t}}
\t}}
\tFallBack "Diffuse"
}}
'''

    # 7. Generic vertex/fragment shader for remaining custom shaders (Arrows, Snow side, Boss Goo, Splatter, Vector, ProBuilder, etc.)
    has_maintex = "_MainTex" in props_block
    has_walltex = "_MainTexWall" in props_block
    has_bubbletex = "_bubbleTex" in props_block
    has_color = "_Color (" in props_block or "_Color(" in props_block
    has_tint = "_TintColor" in props_block
    has_cutoff = "_Cutoff" in props_block or "_AlphaCutoff" in props_block
    has_goocol = "_GooColor (" in props_block
    is_transparent = any(k in low for k in ("transparent", "arrow", "cone", "splatter", "vector", "skidmark", "decal", "solid color", "bubble"))
    is_vcol = "vertexcolor" in low or "vertex color" in low or "vector" in low or "splatter" in low or "skidmark" in low

    queue = "Transparent" if is_transparent else "Geometry"
    render_type = "Transparent" if is_transparent else "Opaque"
    blend_line = "Blend SrcAlpha OneMinusSrcAlpha\n\t\tZWrite Off" if is_transparent else "Blend Off\n\t\tZWrite On"
    cull_line = "Cull Off" if is_transparent else "Cull Back"

    decls = []
    if has_maintex:
        decls.append("sampler2D _MainTex; float4 _MainTex_ST;")
    if has_walltex:
        decls.append("sampler2D _MainTexWall;")
    if has_bubbletex:
        decls.append("sampler2D _bubbleTex;")
    if has_color:
        decls.append("float4 _Color;")
    if has_tint:
        decls.append("float4 _TintColor;")
    if has_goocol:
        decls.append("float4 _GooColor; float _GoopY;")
    if "_Cutoff" in props_block:
        decls.append("float _Cutoff;")
    if "_AlphaCutoff" in props_block:
        decls.append("float _AlphaCutoff;")

    frag_lines = ["float4 col = float4(1, 1, 1, 1);"]
    if is_vcol:
        frag_lines.append("col *= i.color;")
    if has_color:
        frag_lines.append("col *= _Color;")
    if has_tint:
        frag_lines.append("col *= _TintColor * 2.0;")
    if has_maintex:
        frag_lines.append("col *= tex2D(_MainTex, i.uv);")
    elif has_walltex:
        frag_lines.append("col *= tex2D(_MainTexWall, i.wpos.xy * 0.1);")
    elif has_bubbletex:
        frag_lines.append("col *= tex2D(_bubbleTex, i.uv);")
    if has_goocol:
        frag_lines.append("if (i.wpos.y > _GoopY) col.rgb = lerp(col.rgb, _GooColor.rgb, 0.85);")
    if "_Cutoff" in props_block:
        frag_lines.append("clip(col.a - _Cutoff);")
    elif "_AlphaCutoff" in props_block:
        frag_lines.append("clip(col.a - _AlphaCutoff);")
    if not is_transparent:
        frag_lines.append("float3 n = normalize(i.wnorm);")
        frag_lines.append("float3 l = normalize(float3(0.35, 0.85, -0.4));")
        frag_lines.append("col.rgb *= (0.65 + 0.35 * saturate(dot(n, l)));")
    frag_lines.append("return col;")

    decls_str = "\n\t\t\t".join(decls)
    frag_str = "\n\t\t\t\t".join(frag_lines)

    return f'''Shader "{shader_name}" {{
\tProperties {{
{props_block}
\t}}
\tSubShader {{
\t\tTags {{ "Queue"="{queue}" "RenderType"="{render_type}" }}
\t\tLOD 200
\t\t{cull_line}
\t\t{blend_line}
\t\tPass {{
\t\t\tCGPROGRAM
\t\t\t#pragma vertex vert
\t\t\t#pragma fragment frag
\t\t\t#include "UnityCG.cginc"

\t\t\t{decls_str}

\t\t\tstruct appdata {{
\t\t\t\tfloat4 vertex : POSITION;
\t\t\t\tfloat3 normal : NORMAL;
\t\t\t\tfloat2 uv : TEXCOORD0;
\t\t\t\tfloat4 color : COLOR;
\t\t\t}};

\t\t\tstruct v2f {{
\t\t\t\tfloat4 pos : SV_POSITION;
\t\t\t\tfloat3 wnorm : TEXCOORD0;
\t\t\t\tfloat3 wpos : TEXCOORD1;
\t\t\t\tfloat2 uv : TEXCOORD2;
\t\t\t\tfloat4 color : COLOR;
\t\t\t}};

\t\t\tv2f vert(appdata v) {{
\t\t\t\tv2f o;
\t\t\t\to.pos = UnityObjectToClipPos(v.vertex);
\t\t\t\to.wnorm = UnityObjectToWorldNormal(v.normal);
\t\t\t\to.wpos = mul(unity_ObjectToWorld, v.vertex).xyz;
\t\t\t\to.uv = v.uv;
\t\t\t\to.color = v.color;
\t\t\t\treturn o;
\t\t\t}}

\t\t\tfixed4 frag(v2f i) : SV_Target {{
\t\t\t\t{frag_str}
\t\t\t}}
\t\t\tENDCG
\t\t}}
\t}}
\tFallBack "Diffuse"
}}
'''


def process_assets_dir(assets_dir: str) -> int:
    copy_tmpro_cginc(os.path.join(assets_dir, "Shader"))
    copy_tmpro_cginc(os.path.join(assets_dir, "Resources", "shaders"))

    count = 0
    for path in sorted(glob.glob(os.path.join(assets_dir, "**", "*.shader"), recursive=True)):
        txt = open(path, encoding="utf-8", errors="ignore").read()
        if "DummyShaderTextExporter" not in txt and not os.path.basename(path).startswith("tmp_"):
            continue
        m_name = re.search(r'Shader\s+"([^"]+)"', txt)
        if not m_name:
            continue
        shader_name = m_name.group(1)
        m_props = re.search(r"Properties\s*\{(.*?)\n\t\}", txt, re.S)
        props_block = m_props.group(1) if m_props else ""
        rel_path = os.path.relpath(path, assets_dir)
        new_shader = build_cg_shader(shader_name, props_block, rel_path)
        with open(path, "w", encoding="utf-8") as f:
            f.write(new_shader)
        count += 1
    return count


def main() -> None:
    targets = [PORT_ASSETS]
    if len(sys.argv) > 1:
        targets = sys.argv[1:]
    for t in targets:
        if os.path.exists(t):
            n = process_assets_dir(t)
            print(f"Reconstructed {n} shaders in {t}")


if __name__ == "__main__":
    main()
