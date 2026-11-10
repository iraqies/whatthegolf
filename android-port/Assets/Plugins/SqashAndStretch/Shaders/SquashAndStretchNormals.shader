Shader "PicoTanks/SquashAndStretchNormals" {
	Properties {
		_Texture ("Texture", 2D) = "white" {}
		_Color ("Main Color", Vector) = (1,1,1,1)
		_Squash ("Squash", Float) = 0
		_Radius ("Radius", Float) = 0
		_SquashEffect ("SquashEffect", Float) = 1
		_SquashCurve ("SquashCurve", Float) = 0
		_StretchEffect ("StretchEffect", Float) = 1
		_StretchCurve ("StretchCurve", Float) = 0
		_Deviation ("Deviation", Range(0, 1)) = 0.1
		[HideInInspector] __dirty ("", Float) = 1
	}
	SubShader {
		Tags { "Queue"="Geometry" "RenderType"="Opaque" }
		LOD 200
		Cull Back
		Blend Off
		ZWrite On
		Pass {
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			sampler2D _Texture;
			float4 _Texture_ST;
			float4 _Color;
			float _Squash;
			float _Radius;
			float _SquashEffect;
			float _StretchEffect;

			struct appdata {
				float4 vertex : POSITION;
				float3 normal : NORMAL;
				float2 uv : TEXCOORD0;
				float4 color : COLOR;
			};

			struct v2f {
				float4 pos : SV_POSITION;
				float3 wnorm : TEXCOORD0;
				float3 wpos : TEXCOORD1;
				float2 uv : TEXCOORD2;
				float4 color : COLOR;
			};

			v2f vert(appdata v) {
				v2f o;
				float3 localPos = v.vertex.xyz;
				float s = clamp(_Squash, -0.65, 0.65);
				float zScale = max(0.25, 1.0 + s * max(0.2, _SquashEffect));
				float xyScale = 1.0 / sqrt(zScale);
				localPos.xy *= xyScale;
				localPos.z *= zScale;
				o.pos = UnityObjectToClipPos(float4(localPos, v.vertex.w));
				o.wnorm = UnityObjectToWorldNormal(v.normal);
				o.wpos = mul(unity_ObjectToWorld, float4(localPos, v.vertex.w)).xyz;
				o.uv = TRANSFORM_TEX(v.uv, _Texture);
				o.color = v.color;
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				float4 texCol = tex2D(_Texture, i.uv);
				float4 col = texCol * _Color;
				float3 n = normalize(i.wnorm);
				float3 l = normalize(float3(0.35, 0.85, -0.4));
				col.rgb *= (0.72 + 0.28 * saturate(dot(n, l)));
				return col;
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
