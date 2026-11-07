Shader "Toon/Lit" {
	Properties {

		_Color ("Main Color", Vector) = (0.5,0.5,0.5,1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_Ramp ("Toon Ramp (RGB)", 2D) = "gray" {}
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

			sampler2D _MainTex; float4 _MainTex_ST;
			float4 _Color;

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
				o.pos = UnityObjectToClipPos(v.vertex);
				o.wnorm = UnityObjectToWorldNormal(v.normal);
				o.wpos = mul(unity_ObjectToWorld, v.vertex).xyz;
				o.uv = v.uv;
				o.color = v.color;
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				float4 col = float4(1, 1, 1, 1);
				col *= _Color;
				col *= tex2D(_MainTex, i.uv);
				float3 n = normalize(i.wnorm);
				float3 l = normalize(float3(0.35, 0.85, -0.4));
				col.rgb *= (0.65 + 0.35 * saturate(dot(n, l)));
				return col;
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
