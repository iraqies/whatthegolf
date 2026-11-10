Shader "Custom/Arrow" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_LocalLightDir ("Local light direction", Vector) = (0,0,1,0)
		_ShadowRatio ("Shadow Ratio", Range(0, 1)) = 0.685
	}
	SubShader {
		Tags { "Queue"="Geometry" "RenderType"="Opaque" }
		LOD 200

		Pass {
			Cull Back
			ZWrite On
			ZTest LEqual
			Blend Off
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			float4 _Color;
			float4 _LocalLightDir;
			float _ShadowRatio;

			struct appdata {
				float4 vertex : POSITION;
				float3 normal : NORMAL;
			};

			struct v2f {
				float4 pos : SV_POSITION;
				float3 lnorm : TEXCOORD0;
			};

			v2f vert(appdata v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.lnorm = v.normal;
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				float3 n = normalize(i.lnorm);
				float3 l = length(_LocalLightDir.xyz) > 0.001 ? normalize(_LocalLightDir.xyz) : float3(0, 0, 1);
				float shade = dot(n, l) > 0.85 ? 1.0 : (_ShadowRatio > 0.001 ? _ShadowRatio : 0.685);
				return fixed4(_Color.rgb * shade, 1.0);
			}
			ENDCG
		}

		Pass {
			Cull Back
			ZWrite Off
			ZTest Greater
			Blend SrcAlpha OneMinusSrcAlpha
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			float4 _Color;

			struct appdata {
				float4 vertex : POSITION;
			};

			struct v2f {
				float4 pos : SV_POSITION;
			};

			v2f vert(appdata v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				return fixed4(_Color.rgb, _Color.a);
			}
			ENDCG
		}
	}
	FallBack Off
}
