using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x200002F")]
	public struct GlyphPairKey
	{
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x0")]
		public uint firstGlyphIndex;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x4")]
		public uint secondGlyphIndex;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x8")]
		public uint key;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2A7A508", Offset = "0x2A7A508", VA = "0x2A7A508")]
		internal GlyphPairKey(TMP_GlyphPairAdjustmentRecord record)
		{
		}
	}
}
