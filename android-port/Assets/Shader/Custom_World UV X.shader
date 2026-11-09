Shader "Custom/World UV X" {
	Properties {
		_Color ("Main Color", Vector) = (1,1,1,1)
		_MainTexWall ("Wall Side Texture (RGB)", 2D) = "surface" {}
		_Scale ("Texture Scale", Float) = 0.1
	}
	SubShader {
		Tags { "Queue"="Geometry" "RenderType"="Opaque" }
		LOD 200
		Cull Back
		Blend Off
		ZWrite On
		Pass {
			Tags { "LightMode"="ForwardBase" }
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			sampler2D _MainTexWall;
			float4 _Color;
			float _Scale;

			struct appdata {
				float4 vertex : POSITION;
				float3 normal : NORMAL;
			};

			struct v2f {
				float4 pos : SV_POSITION;
				float3 wpos : TEXCOORD0;
				float3 wnorm : TEXCOORD1;
			};

			v2f vert(appdata v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.wpos = mul(unity_ObjectToWorld, v.vertex).xyz;
				o.wnorm = UnityObjectToWorldNormal(v.normal);
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				float sc = _Scale > 0.0001 ? _Scale : 0.1;
				fixed4 tex = tex2D(_MainTexWall, i.wpos.xz * sc);
				return tex * _Color;
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
