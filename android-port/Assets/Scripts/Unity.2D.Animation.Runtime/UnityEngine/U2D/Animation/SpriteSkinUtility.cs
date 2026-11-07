using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Rendering;

namespace UnityEngine.U2D.Animation
{
	internal static class SpriteSkinUtility
	{
		internal static SpriteSkinValidationResult Validate(this SpriteSkin spriteSkin)
		{
			return SpriteSkinValidationResult.SpriteNotFound;
		}

		internal static int GetVertexStreamSize(this Sprite sprite)
		{
			return 0;
		}

		internal static int GetVertexStreamOffset(this Sprite sprite, VertexAttribute channel)
		{
			return 0;
		}

		private static int GetHash(Matrix4x4 matrix)
		{
			return 0;
		}

		internal static int CalculateTransformHash(this SpriteSkin spriteSkin)
		{
			return 0;
		}

		internal static void Deform(Sprite sprite, Matrix4x4 rootInv, NativeSlice<Vector3> vertices, NativeSlice<Vector4> tangents, NativeSlice<BoneWeight> boneWeights, NativeArray<Matrix4x4> boneTransforms, NativeSlice<Matrix4x4> bindPoses, NativeArray<byte> deformableVertices)
		{
		}

		internal static void Deform(float4x4 rootInv, NativeSlice<float3> vertices, NativeSlice<BoneWeight> boneWeights, NativeArray<float4x4> boneTransforms, NativeSlice<float4x4> bindPoses, NativeSlice<float3> deformed)
		{
		}

		internal static void Deform(float4x4 rootInv, NativeSlice<float3> vertices, NativeSlice<float4> tangents, NativeSlice<BoneWeight> boneWeights, NativeArray<float4x4> boneTransforms, NativeSlice<float4x4> bindPoses, NativeSlice<float3> deformed, NativeSlice<float4> deformedTangents)
		{
		}

		internal static void Deform(Sprite sprite, Matrix4x4 invRoot, Transform[] boneTransformsArray, NativeArray<byte> deformVertexData)
		{
		}

		internal static Bounds CalculateSpriteSkinBounds(NativeSlice<float3> deformablePositions)
		{
			return default;
		}

		internal static void UpdateBounds(this SpriteSkin spriteSkin, NativeArray<byte> deformedVertices)
		{
		}
	}
}
