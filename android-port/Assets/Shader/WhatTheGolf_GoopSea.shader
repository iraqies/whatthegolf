Shader "WhatTheGolf/GoopSea" {
	Properties {
		_WaterColor ("Water Color", Vector) = (0.3130562,0.5963172,0.990566,0)
		_FoamDepth ("Foam Depth", Range(0, 10)) = 1
		_Speed ("Speed", Float) = 0.5
		_WaterColor2 ("WaterColor2", Vector) = (0.629,0.2859091,0.2906742,1)
		_Tiling ("Tiling", Vector) = (1,1,0,0)
		_StepThreshold ("StepThreshold", Range(0, 1)) = 0.7
		_Speed2 ("Speed2", Float) = 1
		_FoamColor ("Foam Color", Vector) = (1,1,1,0)
		_NoiseScale ("NoiseScale", Float) = 1
		_PositionToZero ("PositionToZero", Range(0, 1)) = 0.3842759
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
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

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
}