Shader "custom/Golf cone" {
	Properties {

		_TintColor ("Tint Color", Vector) = (0.5,0.5,0.5,0.5)
		_Top ("Top point", Vector) = (0,0,0,1)
		_MainTex ("Particle Texture", 2D) = "white" {}
		_InvFade ("Soft Particles Factor", Range(0.01, 3)) = 1
	}
	SubShader {
		Tags { "Queue"="Transparent" "RenderType"="Transparent" }
		LOD 200
		Cull Off
		Blend SrcAlpha OneMinusSrcAlpha
		ZWrite Off
		Pass {
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			sampler2D _MainTex; float4 _MainTex_ST;
			float4 _TintColor;

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
				col *= _TintColor * 2.0;
				col *= tex2D(_MainTex, i.uv);
				return col;
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
