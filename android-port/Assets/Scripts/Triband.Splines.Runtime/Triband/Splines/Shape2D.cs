using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Triband.Splines
{
	[Token(Token = "0x2000011")]
	public class Shape2D : IEnumerable<Vertex2D>, IEnumerable
	{
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Vertex2D> vertices;

		[Token(Token = "0x1700002C")]
		public int VertexCount
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2A02514", Offset = "0x2A02514", VA = "0x2A02514")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2A020C4", Offset = "0x2A020C4", VA = "0x2A020C4")]
		public Shape2D()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2A0228C", Offset = "0x2A0228C", VA = "0x2A0228C")]
		public void AddVertex(Vertex2D vertex)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2A02560", Offset = "0x2A02560", VA = "0x2A02560")]
		public Vertex2D GetVertex(int index)
		{
			return default;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2A025E8", Offset = "0x2A025E8", VA = "0x2A025E8", Slot = "4")]
		public IEnumerator<Vertex2D> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2A0269C", Offset = "0x2A0269C", VA = "0x2A0269C", Slot = "5")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
