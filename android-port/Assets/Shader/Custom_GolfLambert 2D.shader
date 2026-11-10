Shader "Custom/GolfLambert 2D" {
	Properties {
		[PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
		_Color ("Color", Vector) = (1,1,1,1)
		_ShadowColor ("Shadow Color", Vector) = (1,1,1,1)
		[HideInInspector] _RendererColor ("RendererColor", Vector) = (1,1,1,1)
		[HideInInspector] _Flip ("Flip", Vector) = (1,1,1,1)
	}
	SubShader {
		Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" "PreviewType"="Plane" "CanUseSpriteAtlas"="True" }
		LOD 200
		Cull Off
		Lighting Off
		ZWrite Off
		Blend SrcAlpha OneMinusSrcAlpha
		Pass {
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile_instancing
			#include "UnityCG.cginc"

			sampler2D _MainTex;
			float4 _Color;
			#ifdef UNITY_INSTANCING_ENABLED
				UNITY_INSTANCING_BUFFER_START(PerDrawSprite)
					UNITY_DEFINE_INSTANCED_PROP(fixed4, unity_SpriteRendererColorArray)
					UNITY_DEFINE_INSTANCED_PROP(fixed2, unity_SpriteFlipArray)
				UNITY_INSTANCING_BUFFER_END(PerDrawSprite)
				#define _RendererColor UNITY_ACCESS_INSTANCED_PROP(PerDrawSprite, unity_SpriteRendererColorArray)
				#define _Flip UNITY_ACCESS_INSTANCED_PROP(PerDrawSprite, unity_SpriteFlipArray)
			#else
				fixed4 _RendererColor;
				fixed2 _Flip;
			#endif

			struct appdata {
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
				float4 color : COLOR;
				UNITY_VERTEX_INPUT_INSTANCE_ID
			};

			struct v2f {
				float4 pos : SV_POSITION;
				float2 uv : TEXCOORD0;
				float4 color : COLOR;
				UNITY_VERTEX_OUTPUT_STEREO
			};

			v2f vert(appdata v) {
				v2f o;
				UNITY_SETUP_INSTANCE_ID(v);
				UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);
				float4 vpos = v.vertex;
				fixed2 flip = (abs(_Flip.x) > 0.001 || abs(_Flip.y) > 0.001) ? _Flip.xy : fixed2(1.0, 1.0);
				vpos.xy *= flip;
				o.pos = UnityObjectToClipPos(vpos);
				o.uv = v.uv;
				fixed4 rcol = ( _RendererColor.r + _RendererColor.g + _RendererColor.b + _RendererColor.a ) > 0.0001 ? _RendererColor : fixed4(1,1,1,1);
				o.color = v.color * _Color * rcol;
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				fixed4 tex = tex2D(_MainTex, i.uv);
				return i.color * tex;
			}
			ENDCG
		}
	}
	FallBack "Sprites/Default"
}
