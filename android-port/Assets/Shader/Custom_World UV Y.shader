Shader "Custom/World UV Y" {
	Properties {
		[NoScaleOffset] _MainTex ("Texture", 2D) = "white" {}
		_Color ("Main Color", Vector) = (1,1,1,1)
		_MinBrightness ("Min Brightness", Float) = 0.1
		_MaxBrightness ("Max Brightness", Float) = 1
		_Scale ("Texture Scale", Float) = 0.1
	}
	SubShader {
		Tags { "Queue"="Geometry" "RenderType"="Opaque" }
		LOD 200
		Cull Back
		Blend Off
		ZWrite On
		Pass {
			Tags { "LightMode"="ForwardBase" }
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma target 3.0
			#include "UnityCG.cginc"
			#include "Lighting.cginc"

			sampler2D _MainTex;
			float4 _Color;
			float _MinBrightness;
			float _MaxBrightness;
			float _Scale;

			struct appdata {
				float4 vertex : POSITION;
				float3 normal : NORMAL;
			};

			struct v2f {
				float4 pos : SV_POSITION;
				float3 wpos : TEXCOORD0;
				float3 wnorm : TEXCOORD1;
				nointerpolation half3 flatCol0 : COLOR0;
				nointerpolation half3 flatCol1 : COLOR1;
			};

			v2f vert(appdata v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.wpos = mul(unity_ObjectToWorld, v.vertex).xyz;
				float3 wn = UnityObjectToWorldNormal(v.normal);
				o.wnorm = wn;
				float3 l = any(_WorldSpaceLightPos0.xyz) ? normalize(_WorldSpaceLightPos0.xyz) : normalize(float3(0.25, 0.85, -0.45));
				float3 lc = any(_LightColor0.rgb) ? _LightColor0.rgb : float3(1.0, 1.0, 1.0);
				o.flatCol0 = half3(max(0.0, dot(wn, l)) * lc);
				o.flatCol1 = ShadeSH9(half4(wn, 1.0));
				return o;
			}

			fixed4 frag(v2f i) : SV_Target {
				float3 dx = ddx(i.wpos);
				float3 dy = ddy(i.wpos);
				float3 fn = cross(dx, dy);
				float3 n = (dot(fn, fn) > 1e-8) ? normalize(fn) : normalize(i.wnorm);
				if (dot(n, i.wnorm) < 0.0) n = -n;
				float3 l = any(_WorldSpaceLightPos0.xyz) ? normalize(_WorldSpaceLightPos0.xyz) : normalize(float3(0.25, 0.85, -0.45));
				float3 lc = any(_LightColor0.rgb) ? _LightColor0.rgb : float3(1.0, 1.0, 1.0);
				float3 faceLit = max(0.0, dot(n, l)) * lc + float3(i.flatCol1);
				float3 vertLit = float3(i.flatCol0 + i.flatCol1);
				float3 rawLit = lerp(vertLit, faceLit, 0.65);
				float minB = _MinBrightness > 0.001 ? _MinBrightness : 0.35;
				float maxB = _MaxBrightness > 0.001 ? _MaxBrightness : 1.0;
				float3 br = clamp(rawLit, minB, maxB);
				float sc = _Scale > 0.0001 ? _Scale : 0.05;
				fixed4 tex = tex2D(_MainTex, i.wpos.xy * sc);
				return fixed4(br * tex.rgb * _Color.rgb, 1.0);
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
