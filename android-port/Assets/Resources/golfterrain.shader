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
			#pragma multi_compile_fwdbase
			#include "UnityCG.cginc"
			#include "Lighting.cginc"
			#include "AutoLight.cginc"

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
				float3 wpos : TEXCOORD0;
				float3 wnorm : TEXCOORD1;
				float4 color : COLOR;
				SHADOW_COORDS(2)
			};

			v2f vert(appdata v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.wpos = mul(unity_ObjectToWorld, v.vertex).xyz;
				o.wnorm = UnityObjectToWorldNormal(v.normal);
				o.color = v.color;
				TRANSFER_SHADOW(o);
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				float bw = max(_SkirtBandWidth, 0.1);
				float band = round(frac(i.wpos.y * (0.5 / bw)));
				float3 skirt = lerp(_SkirtColorA.rgb, _SkirtColorB.rgb, band);
				float3 col;
				if (dot(i.color.rgb, float3(1, 1, 1)) > 0.01) {
					col = i.color.r * _SurfaceColor.rgb + i.color.g * _BevelColor.rgb + i.color.b * skirt;
				} else {
					float up = saturate(normalize(i.wnorm).y);
					col = up > 0.85 ? _SurfaceColor.rgb : (up > 0.35 ? _BevelColor.rgb : skirt);
				}
				float3 lc = any(_LightColor0.rgb) ? _LightColor0.rgb : float3(1, 1, 1);
				col *= lc;
				fixed atten = SHADOW_ATTENUATION(i);
				float sh = lerp(_ShadowColor.r, 1.0, atten);
				return fixed4(col * sh, 1.0);
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
