using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Token(Token = "0x2000013")]
	public struct Vertex2D
	{
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x0")]
		public readonly Vector2 position;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x8")]
		public readonly Vector2 uv;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x10")]
		public readonly Vector2 normal;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2A0225C", Offset = "0x2A0225C", VA = "0x2A0225C")]
		public Vertex2D(Vector2 position, Vector2 uv)
		{
		}
	}
}
