Shader "Custom/Screen Flicker" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_MainTex ("Colors Texture", 2D) = "white" {}
		_LineHeight ("Line height", Float) = 0.1
		_FPS ("Frames per second", Float) = 10
		_NumberOfColors ("Number of colors", Float) = 16
		_TimeScale ("Time Scale", Float) = 1
	}
	SubShader {
		Tags { "Queue"="Geometry" "RenderType"="Opaque" }
		LOD 200
		Cull Off
		Pass {
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			sampler2D _MainTex; float4 _MainTex_ST;
			float4 _Color;
			float _LineHeight;
			float _FPS;
			float _NumberOfColors;
			float _TimeScale;

			struct appdata {
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
				float4 color : COLOR;
			};

			struct v2f {
				float4 pos : SV_POSITION;
				float2 uv : TEXCOORD0;
				float4 color : COLOR;
			};

			v2f vert(appdata v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				o.color = v.color;
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				float lh = max(_LineHeight, 0.001);
				float lineIdx = floor(i.uv.y / lh);
				float frameIdx = floor(_Time.y * _FPS * _TimeScale);
				float nColors = max(_NumberOfColors, 1.0);
				float h = frac(sin(lineIdx * 12.9898 + frameIdx * 78.233) * 43758.5453);
				float colorU = (floor(h * nColors) + 0.5) / nColors;
				fixed4 col = tex2D(_MainTex, float2(colorU, 0.5)) * _Color * i.color;
				return col;
			}
			ENDCG
		}
	}
	FallBack "Unlit/Texture"
}
