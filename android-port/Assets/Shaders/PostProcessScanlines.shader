Shader "Custom/PostProcessScanlines" {
	Properties {
		_MainTex ("Screen", 2D) = "black" {}
		_TextureSample0 ("Texture Sample 0", 2D) = "white" {}
		_MoveSpeed ("MoveSpeed", Float) = 0.1
		_Tiling ("Tiling", Vector) = (1,0.2,0,0)
		_Color ("Color", Vector) = (1,1,1,0.16)
		_Radius ("Radius", Float) = 0
		_OutsideColor ("OutsideColor", Vector) = (0,0,0,1)
		_Distortion ("Distortion", Float) = -1
		_k ("k", Float) = -0.15
		_WorldColor ("WorldColor", Vector) = (1,1,1,1)
	}
	SubShader {
		Tags { "Queue"="Overlay" "RenderType"="Transparent" "IgnoreProjector"="True" }
		Cull Off
		ZWrite Off
		ZTest Always
		Blend Off
		Pass {
			CGPROGRAM
			#pragma vertex vert_img
			#pragma fragment frag
			#include "UnityCG.cginc"

			sampler2D _MainTex;
			sampler2D _TextureSample0;
			float _MoveSpeed;
			float4 _Tiling;
			float4 _Color;
			float _Radius;
			float4 _OutsideColor;
			float _Distortion;
			float _k;
			float4 _WorldColor;

			fixed4 frag(v2f_img i) : SV_Target {
				float2 uv = i.uv;
				float2 centered = uv - 0.5;
				float r2 = dot(centered, centered);
				float2 distortedUV = uv + centered * (r2 * _k * _Distortion);
				if (distortedUV.x < 0.0 || distortedUV.x > 1.0 || distortedUV.y < 0.0 || distortedUV.y > 1.0)
					return _OutsideColor;

				fixed4 screenCol = tex2D(_MainTex, distortedUV);
				float2 scanUV = distortedUV * _Tiling.xy + float2(0.0, _Time.y * _MoveSpeed);
				fixed4 scanTex = tex2D(_TextureSample0, scanUV);
				float scanFactor = (1.0 - scanTex.r) * _Color.a;
				float3 rgb = lerp(screenCol.rgb * _WorldColor.rgb, _Color.rgb, saturate(scanFactor));
				return fixed4(rgb, screenCol.a);
			}
			ENDCG
		}
	}
	FallBack Off
}
