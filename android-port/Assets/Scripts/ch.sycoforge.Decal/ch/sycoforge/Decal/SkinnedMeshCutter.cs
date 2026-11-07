using Il2CppDummyDll;
using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000038")]
	public class SkinnedMeshCutter : MeshCutter<DynamicSkinnedMesh>
	{
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x40")]
		private IndexedBone[] indexedBones;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2C6DB48", Offset = "0x2C6DB48", VA = "0x2C6DB48")]
		public SkinnedMeshCutter(EasyDecal parent)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2C6F130", Offset = "0x2C6F130", VA = "0x2C6F130", Slot = "5")]
		protected override void Cut(int indexA, int indexB, sbyte vertexPosA, MathPlane plane)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2C6F608", Offset = "0x2C6F608", VA = "0x2C6F608")]
		private BoneWeight LerpBoneWeights(BoneWeight boneWeightA, BoneWeight boneWeightB, float stretchFactor)
		{
			return default;
		}
	}
}
