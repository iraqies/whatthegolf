using System;
using Il2CppDummyDll;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000025")]
	public struct GlyphValueRecord_Legacy
	{
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x0")]
		public float xPlacement;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x4")]
		public float yPlacement;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x8")]
		public float xAdvance;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0xC")]
		public float yAdvance;
	}
}
