using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x2000082")]
	public struct RichTextTagAttribute
	{
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x0")]
		public int nameHashCode;

		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x4")]
		public int valueHashCode;

		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x8")]
		public TagValueType valueType;

		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0xC")]
		public int valueStartIndex;

		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x10")]
		public int valueLength;

		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x14")]
		public TagUnitType unitType;
	}
}
