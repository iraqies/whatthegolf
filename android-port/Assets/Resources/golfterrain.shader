Shader "Triband/GolfTerrain" {
	Properties {
		_SurfaceColor ("Surface Color", Vector) = (0,0.67,0.63,1)
		_BevelColor ("Bevel Color", Vector) = (0,0.59,0.55,1)
		_SkirtColorA ("Skirt Color A", Vector) = (0.21,0.39,0.43,1)
		_SkirtColorB ("Skirt Color B", Vector) = (0.19,0.35,0.39,1)
		_SkirtBandWidth ("Skirt Band Width", Float) = 5
		_ShadowColor ("Shadow Color", Vector) = (0,0,0,1)
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