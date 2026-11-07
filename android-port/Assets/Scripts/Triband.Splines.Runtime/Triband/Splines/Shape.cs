using System.Collections.Generic;
using Il2CppDummyDll;

namespace Triband.Splines
{
	[Token(Token = "0x2000010")]
	public class Shape
	{
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Vertex> vertices;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<int> triangles;

		[Token(Token = "0x1700002A")]
		public List<Vertex> Vertices
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2A02504", Offset = "0x2A02504", VA = "0x2A02504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public List<int> Triangles
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x2A0250C", Offset = "0x2A0250C", VA = "0x2A0250C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2A02360", Offset = "0x2A02360", VA = "0x2A02360")]
		public Shape()
		{
		}
	}
}
