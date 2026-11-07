using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x200007E")]
	public struct TMP_LinkInfo
	{
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x0")]
		public TMP_Text textComponent;

		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x8")]
		public int hashCode;

		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0xC")]
		public int linkIdFirstCharacterIndex;

		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x10")]
		public int linkIdLength;

		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x14")]
		public int linkTextfirstCharacterIndex;

		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x18")]
		public int linkTextLength;

		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x20")]
		internal char[] linkID;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x2A98714", Offset = "0x2A98714", VA = "0x2A98714")]
		internal void SetLinkID(char[] text, int startIndex, int length)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2A98804", Offset = "0x2A98804", VA = "0x2A98804")]
		public string GetLinkID()
		{
			return null;
		}
	}
}
