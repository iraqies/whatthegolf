using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x200007F")]
	public struct TMP_WordInfo
	{
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x0")]
		public TMP_Text textComponent;

		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x8")]
		public int firstCharacterIndex;

		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0xC")]
		public int lastCharacterIndex;

		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x10")]
		public int characterCount;
	}
}
