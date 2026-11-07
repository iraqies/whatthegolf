Shader "FMVTexture" {
	Properties {

		_MainTex ("Luminance Texture", 2D) = "black" {}
		_ChromaTex ("Chroma Texture", 2D) = "green" {}
	}
	SubShader {
		Cull Off ZWrite Off ZTest Always
		Pass {
			CGPROGRAM
			#pragma vertex vert_img
			#pragma fragment frag
			#include "UnityCG.cginc"
			sampler2D _MainTex;
			sampler2D _ChromaTex;
			fixed4 frag(v2f_img i) : SV_Target {
				float y = tex2D(_MainTex, i.uv).r;
				float2 uv = tex2D(_ChromaTex, i.uv).rg - 0.5;
				float3 rgb = float3(y + 1.402 * uv.y, y - 0.344136 * uv.x - 0.714136 * uv.y, y + 1.772 * uv.x);
				return fixed4(saturate(rgb), 1.0);
			}
			ENDCG
		}
	}
}
