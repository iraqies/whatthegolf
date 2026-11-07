Shader "Custom/GolfLambert" {
	Properties {

		_HighlightColor ("Highlight Color", Vector) = (1,1,1,1)
		_Color ("Albedo Color", Vector) = (1,1,1,1)
		_ShadowColor ("Shadow Color", Vector) = (0,0,0,1)
		_HighlightAmount ("Highlight Amount", Range(0, 2)) = 0
		_HighlightAngle ("Highlight Width", Range(0, 1)) = 1
	}
	SubShader {
		Tags { "RenderType"="Opaque" "Queue"="Geometry" }
		LOD 200
		Cull Back
		Pass {
			Tags { "LightMode"="ForwardBase" }
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

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
			};

			v2f vert(appdata v) {
				v2f o;
				
				o.pos = UnityObjectToClipPos(v.vertex);
				o.wnorm = UnityObjectToWorldNormal(v.normal);
				o.uv = v.uv;
				o.color = v.color;
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				float4 albedo = _Color;
				
				
				float3 n = normalize(i.wnorm);
				float3 l = any(_WorldSpaceLightPos0.xyz) ? normalize(_WorldSpaceLightPos0.xyz) : normalize(float3(0.35, 0.85, -0.4));
				float ndotl = dot(n, l) * 0.5 + 0.5;
				float3 shaded = lerp(albedo.rgb * (1.0 - saturate(_ShadowColor.a) * 0.45) + _ShadowColor.rgb * 0.25, albedo.rgb, saturate(ndotl));
				float hl = smoothstep(1.0 - max(_HighlightAngle, 0.05), 1.0, ndotl) * _HighlightAmount * 0.25;
				shaded = saturate(shaded + _HighlightColor.rgb * hl);
				return fixed4(shaded, albedo.a);
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
