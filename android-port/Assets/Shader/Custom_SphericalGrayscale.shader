Shader "Custom/SphericalGrayscale" {
	Properties {

		_MainTex ("Screen", 2D) = "black" {}
		_PlayerPos ("PlayerPos", Vector) = (0,0,0,0)
		_Player2Pos ("Player2Pos", Vector) = (0,0,0,0)
		_Radius ("Radius", Float) = 0
		_Radius2 ("Radius2", Float) = 0
		_MoveSpeed ("MoveSpeed", Float) = 1
		_NoiseScale ("NoiseScale", Float) = 1
		_UnscaledTime ("UnscaledTime", Float) = 1
		_Intensity ("Intensity", Float) = 1
		_OutlineSize ("OutlineSize", Float) = 2
		_OutlineColorPlayer1 ("OutlineColorPlayer1", Vector) = (1,0,0,1)
		_OutlineColorPlayer2 ("OutlineColorPlayer2", Vector) = (1,0,0,1)
		_AdditionalOffset ("AdditionalOffset", Float) = 0
	}
	SubShader {
		Cull Off ZWrite Off ZTest Always
		Pass {
			CGPROGRAM
			#pragma vertex vert_img
			#pragma fragment frag
			#include "UnityCG.cginc"
			sampler2D _MainTex;
			float _Intensity;
			fixed4 frag(v2f_img i) : SV_Target {
				fixed4 col = tex2D(_MainTex, i.uv);
				float l = dot(col.rgb, float3(0.299, 0.587, 0.114));
				col.rgb = lerp(col.rgb, float3(l, l, l), saturate(_Intensity));
				return col;
			}
			ENDCG
		}
	}
}
