using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Rendering;

namespace UnityEngine.U2D.Animation
{
	[Token(Token = "0x200000C")]
	internal static class SpriteSkinUtility
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2A0FDA4", Offset = "0x2A0FDA4", VA = "0x2A0FDA4")]
		internal static SpriteSkinValidationResult Validate(this SpriteSkin spriteSkin)
		{
			return default;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2A0F370", Offset = "0x2A0F370", VA = "0x2A0F370")]
		internal static int GetVertexStreamSize(this Sprite sprite)
		{
			return default;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2A0F2C8", Offset = "0x2A0F2C8", VA = "0x2A0F2C8")]
		internal static int GetVertexStreamOffset(this Sprite sprite, VertexAttribute channel)
		{
			return default;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2A10070", Offset = "0x2A10070", VA = "0x2A10070")]
		private static int GetHash(Matrix4x4 matrix)
		{
			return default;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2A0F850", Offset = "0x2A0F850", VA = "0x2A0F850")]
		internal static int CalculateTransformHash(this SpriteSkin spriteSkin)
		{
			return default;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2A10080", Offset = "0x2A10080", VA = "0x2A10080")]
		internal static void Deform(Sprite sprite, Matrix4x4 rootInv, NativeSlice<Vector3> vertices, NativeSlice<Vector4> tangents, NativeSlice<BoneWeight> boneWeights, NativeArray<Matrix4x4> boneTransforms, NativeSlice<Matrix4x4> bindPoses, NativeArray<byte> deformableVertices)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2A110FC", Offset = "0x2A110FC", VA = "0x2A110FC")]
		internal static void Deform(float4x4 rootInv, NativeSlice<float3> vertices, NativeSlice<BoneWeight> boneWeights, NativeArray<float4x4> boneTransforms, NativeSlice<float4x4> bindPoses, NativeSlice<float3> deformed)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2A10404", Offset = "0x2A10404", VA = "0x2A10404")]
		internal static void Deform(float4x4 rootInv, NativeSlice<float3> vertices, NativeSlice<float4> tangents, NativeSlice<BoneWeight> boneWeights, NativeArray<float4x4> boneTransforms, NativeSlice<float4x4> bindPoses, NativeSlice<float3> deformed, NativeSlice<float4> deformedTangents)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2A0F958", Offset = "0x2A0F958", VA = "0x2A0F958")]
		internal static void Deform(Sprite sprite, Matrix4x4 invRoot, Transform[] boneTransformsArray, NativeArray<byte> deformVertexData)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2A11A74", Offset = "0x2A11A74", VA = "0x2A11A74")]
		internal static Bounds CalculateSpriteSkinBounds(NativeSlice<float3> deformablePositions)
		{
			return default;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2A0FB80", Offset = "0x2A0FB80", VA = "0x2A0FB80")]
		internal static void UpdateBounds(this SpriteSkin spriteSkin, NativeArray<byte> deformedVertices)
		{
		}
	}
}
