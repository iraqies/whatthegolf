using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x200007D")]
	public struct TMP_PageInfo
	{
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x0")]
		public int firstCharacterIndex;

		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x4")]
		public int lastCharacterIndex;

		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x8")]
		public float ascender;

		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0xC")]
		public float baseLine;

		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x10")]
		public float descender;
	}
}
