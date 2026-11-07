Shader "CameraFilterPack/TV_VHS_Rewind" {
	Properties {

		_MainTex ("Base (RGB)", 2D) = "white" {}
		_TimeX ("Time", Range(0, 1)) = 1
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
			float _TimeX;
			fixed4 frag(v2f_img i) : SV_Target {
				float2 uv = i.uv;
				uv.x += sin(uv.y * 40.0 + _TimeX * 15.0) * 0.003;
				fixed4 col = tex2D(_MainTex, uv);
				return col;
			}
			ENDCG
		}
	}
}
