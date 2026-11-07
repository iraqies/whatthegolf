using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	[Token(Token = "0x2000030")]
	public class DynamicSkinnedMesh : DynamicMesh
	{
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x6C")]
		private SkinQuality skinQuality;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x70")]
		private Transform[] bones;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x78")]
		private Matrix4x4[] bindPoses;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x80")]
		private List<BoneWeight> bonesWeights;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x88")]
		private BoneWeight[] originalBonesWeights;

		[Token(Token = "0x17000060")]
		public Transform[] Bones
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x2C61A54", Offset = "0x2C61A54", VA = "0x2C61A54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public List<BoneWeight> BonesWeights
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x2C61A5C", Offset = "0x2C61A5C", VA = "0x2C61A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2C61A64", Offset = "0x2C61A64", VA = "0x2C61A64")]
		internal DynamicSkinnedMesh(DecalBase parent, RecreationMode mode)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2C61B30", Offset = "0x2C61B30", VA = "0x2C61B30")]
		public void Add(Mesh mesh, Transform[] bones, Matrix4x4 localToWorld)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2C61D14", Offset = "0x2C61D14", VA = "0x2C61D14", Slot = "15")]
		internal override void RemoveRange(int startIndex, int count)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2C61D90", Offset = "0x2C61D90", VA = "0x2C61D90", Slot = "13")]
		protected override void OnProcessVertexIndex(int index, bool valid)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2C61E38", Offset = "0x2C61E38", VA = "0x2C61E38", Slot = "14")]
		public override Mesh ConvertToMesh(Mesh target, bool reset = false)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2C6206C", Offset = "0x2C6206C", VA = "0x2C6206C", Slot = "11")]
		public override void Clear()
		{
		}
	}
}
