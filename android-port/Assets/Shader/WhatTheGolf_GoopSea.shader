Shader "WhatTheGolf/GoopSea" {
	Properties {

		_WaterColor ("Water Color", Vector) = (0.3130562,0.5963172,0.990566,0)
		_FoamDepth ("Foam Depth", Range(0, 10)) = 1
		_Speed ("Speed", Float) = 0.5
		_WaterColor2 ("WaterColor2", Vector) = (0.629,0.2859091,0.2906742,1)
		_Tiling ("Tiling", Vector) = (1,1,0,0)
		_StepThreshold ("StepThreshold", Range(0, 1)) = 0.7
		_Speed2 ("Speed2", Float) = 1
		_FoamColor ("Foam Color", Vector) = (1,1,1,0)
		_NoiseScale ("NoiseScale", Float) = 1
		_PositionToZero ("PositionToZero", Range(0, 1)) = 0.3842759
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
			float4 _WaterColor2;

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
				float3 rgb = lerp(_WaterColor.rgb, _WaterColor2.rgb, wave * 0.35);
				return fixed4(rgb, 1.0);
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
