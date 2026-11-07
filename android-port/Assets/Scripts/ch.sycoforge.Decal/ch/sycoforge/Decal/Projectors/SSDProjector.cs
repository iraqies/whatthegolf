using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors
{
	[Serializable]
	[Token(Token = "0x200003B")]
	internal class SSDProjector : Projector
	{
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3[] vertices;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x8")]
		private static int[] triangles;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x28")]
		internal Vector3[] normals;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x30")]
		internal Vector2[] uv;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x38")]
		internal Vector2[] uv2;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x40")]
		internal Color[] colors;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x48")]
		private bool isVisible;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x10")]
		private static Vector3 extents;

		[Token(Token = "0x1700006A")]
		public override bool IsVisible
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x2C6CE5C", Offset = "0x2C6CE5C", VA = "0x2C6CE5C", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2C6CE64", Offset = "0x2C6CE64", VA = "0x2C6CE64")]
		internal SSDProjector(EasyDecal decal)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2C6D040", Offset = "0x2C6D040", VA = "0x2C6D040")]
		private void CreateStatics()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2C6D570", Offset = "0x2C6D570", VA = "0x2C6D570")]
		private void CreateDynamics()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2C6D688", Offset = "0x2C6D688", VA = "0x2C6D688")]
		private void CreateCubeMesh()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2C6D6AC", Offset = "0x2C6D6AC", VA = "0x2C6D6AC", Slot = "7")]
		internal override void OnGeometryPropertyChanged()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2C6D768", Offset = "0x2C6D768", VA = "0x2C6D768", Slot = "6")]
		internal override void Update()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2C6D76C", Offset = "0x2C6D76C", VA = "0x2C6D76C", Slot = "12")]
		internal override void Project()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2C6CE8C", Offset = "0x2C6CE8C", VA = "0x2C6CE8C")]
		private void InitializeProjectionCube()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2C6D794", Offset = "0x2C6D794", VA = "0x2C6D794", Slot = "11")]
		internal override void DrawGizmos(bool selected)
		{
		}
	}
}
