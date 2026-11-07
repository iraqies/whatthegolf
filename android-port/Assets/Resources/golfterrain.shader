Shader "Triband/GolfTerrain" {
	Properties {

		_SurfaceColor ("Surface Color", Vector) = (0,0.67,0.63,1)
		_BevelColor ("Bevel Color", Vector) = (0,0.59,0.55,1)
		_SkirtColorA ("Skirt Color A", Vector) = (0.21,0.39,0.43,1)
		_SkirtColorB ("Skirt Color B", Vector) = (0.19,0.35,0.39,1)
		_SkirtBandWidth ("Skirt Band Width", Float) = 5
		_ShadowColor ("Shadow Color", Vector) = (0,0,0,1)
	}
	SubShader {
		Tags { "RenderType"="Opaque" "Queue"="Geometry" }
		LOD 200
		Pass {
			Tags { "LightMode"="ForwardBase" }
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			float4 _SurfaceColor;
			float4 _BevelColor;
			float4 _SkirtColorA;
			float4 _SkirtColorB;
			float _SkirtBandWidth;
			float4 _ShadowColor;

			struct appdata {
				float4 vertex : POSITION;
				float3 normal : NORMAL;
				float4 color : COLOR;
			};

			struct v2f {
				float4 pos : SV_POSITION;
				float3 wnorm : TEXCOORD0;
				float3 wpos : TEXCOORD1;
				float4 color : COLOR;
			};

			v2f vert(appdata v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.wnorm = UnityObjectToWorldNormal(v.normal);
				o.wpos = mul(unity_ObjectToWorld, v.vertex).xyz;
				o.color = v.color;
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				float3 n = normalize(i.wnorm);
				float up = saturate(n.y);
				float band = frac(i.wpos.y / max(_SkirtBandWidth, 0.1)) > 0.5 ? 1.0 : 0.0;
				float4 skirt = lerp(_SkirtColorA, _SkirtColorB, band);
				float4 baseCol = up > 0.85 ? _SurfaceColor : (up > 0.35 ? _BevelColor : skirt);
				float3 l = normalize(_WorldSpaceLightPos0.xyz + float3(0.3, 0.8, -0.4));
				float ndotl = saturate(dot(n, l));
				float3 rgb = lerp(baseCol.rgb * (1.0 - _ShadowColor.a * 0.35) + _ShadowColor.rgb * 0.2, baseCol.rgb, 0.55 + 0.45 * ndotl);
				return fixed4(rgb, 1.0);
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
