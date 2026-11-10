Shader "Custom/TubeShading" {
	Properties {
		_HighlightColor ("Highlight Color", Vector) = (1,1,1,1)
		_Color ("Albedo Color", Vector) = (1,1,1,1)
		_ShadowColor ("Shadow Color", Vector) = (1,1,1,1)
		_HighlightAmount ("Highlight Amount", Float) = 1.2
		_HighlightAngle ("Highlight Width", Float) = 0.58
		_MainTex ("Albedo Texture", 2D) = "white" {}
	}
	SubShader {
		Tags { "Queue"="Transparent" "RenderType"="Transparent" "IgnoreProjector"="True" }
		LOD 200
		Cull Off
		ZWrite Off
		Blend SrcAlpha OneMinusSrcAlpha
		Pass {
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			sampler2D _MainTex; float4 _MainTex_ST;
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
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				o.color = v.color;
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				fixed4 tex = tex2D(_MainTex, i.uv);
				float nlenSq = dot(i.wnorm, i.wnorm);
				float3 n = nlenSq > 1e-5 ? (i.wnorm * rsqrt(nlenSq)) : float3(0.0, 0.0, -1.0);
				float3 l = normalize(float3(0.35, 0.85, -0.4));
				float ndotl = nlenSq > 1e-5 ? dot(n, l) : (1.0 - abs(i.uv.y - 0.35) * 2.0);
				float ha = max(_HighlightAngle, 0.01);
				float hl = saturate((ndotl - (1.0 - ha)) / ha);
				float3 baseCol = lerp(_Color.rgb, _HighlightColor.rgb, saturate(hl * 0.45));
				float3 rgb = tex.rgb * baseCol * i.color.rgb;
				fixed alpha = saturate(tex.a * _Color.a * i.color.a);
				return fixed4(rgb, alpha);
			}
			ENDCG
		}
	}
	FallBack "Sprites/Default"
}
