using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x2000047")]
	public struct TMP_MeshInfo
	{
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color32 s_DefaultColor;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Vector3 s_DefaultNormal;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector4 s_DefaultTangent;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Bounds s_DefaultBounds;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x0")]
		public Mesh mesh;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x8")]
		public int vertexCount;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x10")]
		public Vector3[] vertices;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x18")]
		public Vector3[] normals;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x20")]
		public Vector4[] tangents;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x28")]
		public Vector2[] uvs0;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x30")]
		public Vector2[] uvs2;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x38")]
		public Color32[] colors32;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x40")]
		public int[] triangles;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x48")]
		public Material material;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2A9A010", Offset = "0x2A9A010", VA = "0x2A9A010")]
		public TMP_MeshInfo(Mesh mesh, int size)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2A9A4B0", Offset = "0x2A9A4B0", VA = "0x2A9A4B0")]
		public void ResizeMeshInfo(int size)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2A9A8B0", Offset = "0x2A9A8B0", VA = "0x2A9A8B0")]
		public void ResizeMeshInfo(int size, bool isVolumetric)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2A9B02C", Offset = "0x2A9B02C", VA = "0x2A9B02C")]
		public void Clear(bool uploadChanges)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2A9B190", Offset = "0x2A9B190", VA = "0x2A9B190")]
		public void ClearUnusedVertices()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2A9B1C8", Offset = "0x2A9B1C8", VA = "0x2A9B1C8")]
		public void ClearUnusedVertices(int startIndex, bool updateMesh)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2A9B2A0", Offset = "0x2A9B2A0", VA = "0x2A9B2A0")]
		public void SortGeometry(VertexSortingOrder order)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2A9B324", Offset = "0x2A9B324", VA = "0x2A9B324")]
		public void SwapVertexData(int src, int dst)
		{
		}
	}
}
