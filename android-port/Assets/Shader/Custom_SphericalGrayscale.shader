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
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
	//CustomEditor "ASEMaterialInspector"
}