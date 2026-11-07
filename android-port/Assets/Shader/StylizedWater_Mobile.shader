Shader "StylizedWater/Mobile" {
	Properties {

		[HideInInspector] __dirty ("", Float) = 1
		_WaterColor ("Water Color", Vector) = (0.1176471,0.6348885,1,0)
		_WaterShallowColor ("WaterShallowColor", Vector) = (0.4191176,0.7596349,1,0)
		_Wavetint ("Wave tint", Range(-1, 1)) = 0
		_RimColor ("Rim Color", Vector) = (1,1,1,0.5019608)
		_NormalStrength ("NormalStrength", Range(0, 1)) = 0.25
		_Transparency ("Transparency", Range(0, 1)) = 0.75
		_Glossiness ("Glossiness", Range(0, 1)) = 0.85
		_Worldspacetiling ("Worldspace tiling", Float) = 1
		_NormalTiling ("NormalTiling", Range(0, 1)) = 0.9
		_EdgeFade ("EdgeFade", Range(0.01, 3)) = 0.2448298
		_RimSize ("Rim Size", Range(0, 20)) = 5
		_Rimfalloff ("Rim falloff", Range(0.1, 50)) = 3
		_Rimtiling ("Rim tiling", Float) = 0.5
		_FoamOpacity ("FoamOpacity", Range(-1, 1)) = 0.05
		_FoamSpeed ("FoamSpeed", Range(0, 1)) = 0.1
		_FoamSize ("FoamSize", Float) = 0
		_FoamTiling ("FoamTiling", Float) = 0.05
		_Depth ("Depth", Range(0, 100)) = 30
		_Wavesspeed ("Waves speed", Range(0, 10)) = 0.75
		_WaveHeight ("Wave Height", Range(0, 1)) = 0.05
		_WaveFoam ("Wave Foam", Range(0, 10)) = 0
		_WaveSize ("Wave Size", Range(0, 10)) = 0.1
		_WaveDirection ("WaveDirection", Vector) = (1,0,0,0)
		[Toggle] _USE_VC_INTERSECTION ("USE_VC_INTERSECTION", Float) = 0
		[Toggle] _UseIntersectionFoam ("UseIntersectionFoam", Float) = 0
		[Toggle] _ENABLE_VC ("ENABLE_VC", Float) = 0
		[Toggle] _LIGHTING ("LIGHTING", Float) = 0
		[NoScaleOffset] [Normal] _Normals ("Normals", 2D) = "bump" {}
		[Toggle] _Unlit ("Unlit", Float) = 0
		[NoScaleOffset] _Shadermap ("Shadermap", 2D) = "black" {}
		[Toggle] _NORMAL_MAP ("NORMAL_MAP", Float) = 0
	}
	SubShader {
		Tags { "RenderType"="Opaque" "Queue"="Geometry" }
		LOD 200
		Pass {
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			float4 _WaterColor;
			float4 _WaterShallowColor;

			struct appdata {
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f {
				float4 pos : SV_POSITION;
				float3 wpos : TEXCOORD0;
			};

			v2f vert(appdata v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.wpos = mul(unity_ObjectToWorld, v.vertex).xyz;
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				float wave = sin(i.wpos.x * 0.6 + _Time.y * 1.5) * cos(i.wpos.z * 0.6 + _Time.y * 1.2) * 0.5 + 0.5;
				float3 rgb = lerp(_WaterColor.rgb, _WaterShallowColor.rgb, wave * 0.35);
				return fixed4(rgb, 1.0);
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
