Shader "Custom/GolfLambertWaveGraph" {
	Properties {
		_Color ("Color", Vector) = (0,0,0,0)
		_ShadowColor ("ShadowColor", Vector) = (0,0,0,0)
		_HighlightColor ("HighlightColor", Vector) = (0,0,0,0)
		_HighlightAngle ("HighlightAngle", Range(0, 1)) = 0
		_HighlightAmount ("HighlightAmount", Range(0, 2)) = 0
		_WaveSize ("WaveSize", Float) = 1
		_WaveSpeed ("WaveSpeed", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 _Color;

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return _Color; // RGBA
			}

			ENDHLSL
		}
	}
	//CustomEditor "ASEMaterialInspector"
}