using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000075")]
	public class VertexHelper : IDisposable
	{
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x10")]
		private List<Vector3> m_Positions;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x18")]
		private List<Color32> m_Colors;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x20")]
		private List<Vector4> m_Uv0S;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x28")]
		private List<Vector4> m_Uv1S;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x30")]
		private List<Vector4> m_Uv2S;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x38")]
		private List<Vector4> m_Uv3S;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x40")]
		private List<Vector3> m_Normals;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x48")]
		private List<Vector4> m_Tangents;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x50")]
		private List<int> m_Indices;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector4 s_DefaultTangent;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector3 s_DefaultNormal;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x58")]
		private bool m_ListsInitalized;

		[Token(Token = "0x1700014F")]
		public int currentVertCount
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x2C43D08", Offset = "0x2C43D08", VA = "0x2C43D08")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x2C43700", Offset = "0x2C43700", VA = "0x2C43700")]
		public VertexHelper()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2C43708", Offset = "0x2C43708", VA = "0x2C43708")]
		public VertexHelper(Mesh m)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2C43948", Offset = "0x2C43948", VA = "0x2C43948")]
		private void InitializeListIfRequired()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x2C43B04", Offset = "0x2C43B04", VA = "0x2C43B04", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x2C3A418", Offset = "0x2C3A418", VA = "0x2C3A418")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2C43D58", Offset = "0x2C43D58", VA = "0x2C43D58")]
		public void PopulateUIVertex(ref UIVertex vertex, int i)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2C43F4C", Offset = "0x2C43F4C", VA = "0x2C43F4C")]
		public void SetUIVertex(UIVertex vertex, int i)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2C440B4", Offset = "0x2C440B4", VA = "0x2C440B4")]
		public void FillMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2C44220", Offset = "0x2C44220", VA = "0x2C44220")]
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2C4442C", Offset = "0x2C4442C", VA = "0x2C4442C")]
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2C44518", Offset = "0x2C44518", VA = "0x2C44518")]
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2C44658", Offset = "0x2C44658", VA = "0x2C44658")]
		public void AddVert(UIVertex v)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2C446F0", Offset = "0x2C446F0", VA = "0x2C446F0")]
		public void AddTriangle(int idx0, int idx1, int idx2)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2C40D3C", Offset = "0x2C40D3C", VA = "0x2C40D3C")]
		public void AddUIVertexQuad(UIVertex[] verts)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2C3A54C", Offset = "0x2C3A54C", VA = "0x2C3A54C")]
		public void AddUIVertexTriangleStream(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2C3A3C4", Offset = "0x2C3A3C4", VA = "0x2C3A3C4")]
		public void GetUIVertexStream(List<UIVertex> stream)
		{
		}
	}
}
