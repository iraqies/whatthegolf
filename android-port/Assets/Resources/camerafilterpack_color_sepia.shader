Shader "CameraFilterPack/Color_Sepia" {
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
				float3 s = float3(dot(col.rgb, float3(0.393, 0.769, 0.189)), dot(col.rgb, float3(0.349, 0.686, 0.168)), dot(col.rgb, float3(0.272, 0.534, 0.131)));
				return fixed4(saturate(s), col.a);
			}
			ENDCG
		}
	}
}
