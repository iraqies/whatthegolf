Shader "Custom/Invisible" {
	Properties {

	}
	SubShader {
		Tags { "Queue"="Transparent" "RenderType"="Transparent" }
		Pass {
			ColorMask 0
			ZWrite Off
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
