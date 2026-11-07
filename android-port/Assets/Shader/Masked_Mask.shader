Shader "Masked/Mask" {
	Properties {

	}
	SubShader {
		Tags { "Queue"="Geometry-10" "RenderType"="Opaque" }
		ColorMask 0
		ZWrite On
		Pass {
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"
			float4 vert(float4 v : POSITION) : SV_POSITION { return UnityObjectToClipPos(v); }
			fixed4 frag() : SV_Target { return 0; }
			ENDCG
		}
	}
}
