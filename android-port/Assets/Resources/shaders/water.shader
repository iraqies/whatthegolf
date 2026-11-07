Shader "Custom/SurfaceDepthTextureColorized" {
	Properties {

		_Color ("Color", Vector) = (1,1,1,1)
		_BlendColor ("Blend Color", Vector) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0, 1)) = 0.5
		_Metallic ("Metallic", Range(0, 1)) = 0
		_InvFade ("Soft Factor", Range(0.01, 3)) = 1
		_FadeLimit ("Fade Limit", Range(0, 1)) = 0.3
	}
	SubShader {
		Tags { "RenderType"="Opaque" "Queue"="Geometry" }
		LOD 200
		Pass {
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			float4 _Color;
			float4 _BlendColor;

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
				float3 rgb = lerp(_Color.rgb, _BlendColor.rgb, wave * 0.35);
				return fixed4(rgb, 1.0);
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
