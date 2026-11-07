Shader "Custom/bubbleBurst" {
	Properties {

		_bubbleTex ("bubbleTex", 2D) = "white" {}
		_Color ("Color", Vector) = (0.5,0.5,0.5,1)
		[HideInInspector] _Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
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

			sampler2D _bubbleTex;
			float4 _Color;
			float _Cutoff;

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
				col *= tex2D(_bubbleTex, i.uv);
				clip(col.a - _Cutoff);
				return col;
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
