using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	[Token(Token = "0x2000037")]
	public class SimpleMesh : IMesh
	{
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x10")]
		protected List<Vector2> uv;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x18")]
		protected List<Vector2> uv2;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x20")]
		protected List<Vector3> vertices;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x28")]
		protected List<Vector3> normals;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x30")]
		protected List<Vector4> tangents;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x38")]
		protected List<Color> vertexColors;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x40")]
		internal List<int> triangleIndices;

		[Token(Token = "0x17000064")]
		public List<Vector3> Vertices
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x2C6D884", Offset = "0x2C6D884", VA = "0x2C6D884", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		public List<Vector3> Normals
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x2C6D88C", Offset = "0x2C6D88C", VA = "0x2C6D88C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public List<Vector4> Tangents
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x2C6D894", Offset = "0x2C6D894", VA = "0x2C6D894", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public List<Color> VertexColors
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x2C6D89C", Offset = "0x2C6D89C", VA = "0x2C6D89C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public List<int> TriangleIndices
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x2C6D8A4", Offset = "0x2C6D8A4", VA = "0x2C6D8A4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public List<Vector2> UV
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x2C6D8AC", Offset = "0x2C6D8AC", VA = "0x2C6D8AC", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2C6D8B4", Offset = "0x2C6D8B4", VA = "0x2C6D8B4")]
		public SimpleMesh()
		{
		}
	}
}
