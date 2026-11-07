using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x2000080")]
	public struct Extents
	{
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0x0")]
		internal static Extents zero;

		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x10")]
		internal static Extents uninitialized;

		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 min;

		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 max;

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2A79F78", Offset = "0x2A79F78", VA = "0x2A79F78")]
		public Extents(Vector2 min, Vector2 max)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2A79F84", Offset = "0x2A79F84", VA = "0x2A79F84", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
