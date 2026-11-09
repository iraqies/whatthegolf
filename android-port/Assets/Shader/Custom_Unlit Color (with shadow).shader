Shader "Custom/Unlit Color (with shadow)" {
	Properties {
		_Color ("Albedo Color", Vector) = (1,1,1,1)
		_ShadowAmount ("Shadow Amount", Float) = 1
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
			#pragma multi_compile_fwdbase
			#include "UnityCG.cginc"
			#include "AutoLight.cginc"

			float4 _Color;
			float _ShadowAmount;

			struct appdata {
				float4 vertex : POSITION;
			};

			struct v2f {
				float4 pos : SV_POSITION;
				SHADOW_COORDS(0)
			};

			v2f vert(appdata v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				TRANSFER_SHADOW(o);
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				fixed atten = SHADOW_ATTENUATION(i);
				float s = lerp(1.0 - _ShadowAmount, 1.0, atten);
				return fixed4(_Color.rgb * s, _Color.a);
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
