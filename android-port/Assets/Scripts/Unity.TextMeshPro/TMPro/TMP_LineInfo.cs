using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x2000040")]
	public struct TMP_LineInfo
	{
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x0")]
		internal int controlCharacterCount;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x4")]
		public int characterCount;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x8")]
		public int visibleCharacterCount;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0xC")]
		public int spaceCount;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x10")]
		public int wordCount;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x14")]
		public int firstCharacterIndex;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x18")]
		public int firstVisibleCharacterIndex;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x1C")]
		public int lastCharacterIndex;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x20")]
		public int lastVisibleCharacterIndex;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x24")]
		public float length;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x28")]
		public float lineHeight;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x2C")]
		public float ascender;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x30")]
		public float baseline;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x34")]
		public float descender;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x38")]
		public float maxAdvance;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x3C")]
		public float width;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x40")]
		public float marginLeft;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x44")]
		public float marginRight;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x48")]
		public HorizontalAlignmentOptions alignment;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x4C")]
		public Extents lineExtents;
	}
}
