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
				fixed4 color : COLOR0;
			};

			v2f vert(appdata v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				float3 n = normalize(v.normal);
				float3 l = length(_LocalLightDir.xyz) > 0.001 ? normalize(_LocalLightDir.xyz) : float3(0, 0, 1);
				float sr = _ShadowRatio > 0.001 ? _ShadowRatio : 0.685;
				float shade = abs(dot(n, l)) * (1.0 - sr) + sr;
				o.color = fixed4(_Color.rgb * shade, 1.0);
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				return i.color;
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
			float4 _LocalLightDir;
			float _ShadowRatio;

			struct appdata {
				float4 vertex : POSITION;
				float3 normal : NORMAL;
			};

			struct v2f {
				float4 pos : SV_POSITION;
				fixed4 color : COLOR0;
			};

			v2f vert(appdata v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				float3 n = normalize(v.normal);
				float3 l = length(_LocalLightDir.xyz) > 0.001 ? normalize(_LocalLightDir.xyz) : float3(0, 0, 1);
				float sr = _ShadowRatio > 0.001 ? _ShadowRatio : 0.685;
				float shade = abs(dot(n, l)) * (1.0 - sr) + sr;
				o.color = fixed4(_Color.rgb * shade, _Color.a * shade);
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				return i.color;
			}
			ENDCG
		}
	}
	FallBack Off
}
