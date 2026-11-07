Shader "CameraFilterPack/Color_GrayScale" {
	Properties {

		_MainTex ("Base (RGB)", 2D) = "white" {}
		_TimeX ("Time", Range(0, 1)) = 1
		_Distortion ("_Distortion", Range(0, 1)) = 1
		_ScreenResolution ("_ScreenResolution", Vector) = (0,0,0,0)
	}
	SubShader {
		Cull Off ZWrite Off ZTest Always
		Pass {
			CGPROGRAM
			#pragma vertex vert_img
			#pragma fragment frag
			#include "UnityCG.cginc"
			sampler2D _MainTex;
			
			fixed4 frag(v2f_img i) : SV_Target {
				fixed4 col = tex2D(_MainTex, i.uv);
				float l = dot(col.rgb, float3(0.299, 0.587, 0.114));
				return fixed4(l, l, l, col.a);
			}
			ENDCG
		}
	}
}
