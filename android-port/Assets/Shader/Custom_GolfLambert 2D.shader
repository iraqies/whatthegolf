Shader "Custom/GolfLambert 2D" {
	Properties {


		_Color ("Color", Vector) = (1,1,1,1)
		_ShadowColor ("Shadow Color", Vector) = (0,0,0,1)
	}
	SubShader {
		Tags { "RenderType"="Opaque" "Queue"="Geometry" }
		LOD 200
		Cull Off
		Pass {
			Tags { "LightMode"="ForwardBase" }
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile_fwdbase
			#include "UnityCG.cginc"
			#include "Lighting.cginc"
			#include "AutoLight.cginc"

			float4 _Color;
			float4 _HighlightColor;
			float4 _ShadowColor;
			float _HighlightAmount;
			float _HighlightAngle;
			

			struct appdata {
				float4 vertex : POSITION;
				float3 normal : NORMAL;
				float2 uv : TEXCOORD0;
				float4 color : COLOR;
			};

			struct v2f {
				float4 pos : SV_POSITION;
				float3 wnorm : TEXCOORD0;
				float2 uv : TEXCOORD1;
				float4 color : COLOR;
				SHADOW_COORDS(2)
			};

			v2f vert(appdata v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.wnorm = UnityObjectToWorldNormal(v.normal);
				o.uv = v.uv;
				o.color = v.color;
				TRANSFER_SHADOW(o);
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				float3 n = normalize(i.wnorm);
				float3 l = any(_WorldSpaceLightPos0.xyz) ? normalize(_WorldSpaceLightPos0.xyz) : normalize(float3(0.35, 0.85, -0.4));
				float t = clamp((dot(n, l) - 0.25) * 1.3, 0.0, 1.0) + 0.2;
				float3 col = lerp(_ShadowColor.rgb, _Color.rgb, t);
				fixed atten = SHADOW_ATTENUATION(i);
				return fixed4(col * atten, 1.0);
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
