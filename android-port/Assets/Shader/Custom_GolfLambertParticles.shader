Shader "Custom/GolfLambertParticles" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_ShadowColor ("Shadow Color", Vector) = (0,0,0,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_HighlightColor ("Highlight Color", Vector) = (1,1,1,1)
		_HighlightAmount ("Highlight Amount", Range(0, 2)) = 0
		_HighlightAngle ("Highlight Width", Range(0, 1)) = 1
	}
	SubShader {
		Tags { "RenderType"="Transparent" "Queue"="Transparent" "IgnoreProjector"="True" }
		LOD 200
		Cull Off
		ZWrite Off
		Blend SrcAlpha OneMinusSrcAlpha
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
			sampler2D _MainTex; float4 _MainTex_ST;

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
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				o.color = v.color;
				TRANSFER_SHADOW(o);
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				float4 tex = tex2D(_MainTex, i.uv);
				float3 n = normalize(i.wnorm);
				float3 l = any(_WorldSpaceLightPos0.xyz) ? normalize(_WorldSpaceLightPos0.xyz) : normalize(float3(0.35, 0.85, -0.4));
				float3 lc = any(_LightColor0.rgb) ? _LightColor0.rgb : float3(1.0, 1.0, 1.0);
				float ndotl = dot(n, l);
				float ha = max(_HighlightAngle, 0.001);
				float hl = saturate((ndotl - (1.0 - ha)) / ha);
				float3 lit = ((tex.rgb * (_Color.rgb * i.color.rgb)) + _HighlightColor.rgb * hl * _HighlightAmount) * lc;
				float back = saturate(-ndotl);
				float3 shade = lerp(float3(1.0, 1.0, 1.0), _ShadowColor.rgb, back);
				fixed atten = SHADOW_ATTENUATION(i);
				fixed alpha = saturate(tex.a * _Color.a * i.color.a);
				return fixed4(lit * shade * atten, alpha);
			}
			ENDCG
		}
	}
	FallBack "Particles/Alpha Blended"
}
