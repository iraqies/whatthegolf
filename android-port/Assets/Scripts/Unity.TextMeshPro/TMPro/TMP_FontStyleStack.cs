using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x2000072")]
	public struct TMP_FontStyleStack
	{
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x0")]
		public byte bold;

		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x1")]
		public byte italic;

		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x2")]
		public byte underline;

		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x3")]
		public byte strikethrough;

		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x4")]
		public byte highlight;

		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x5")]
		public byte superscript;

		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x6")]
		public byte subscript;

		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x7")]
		public byte uppercase;

		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x8")]
		public byte lowercase;

		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x9")]
		public byte smallcaps;

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2A89EC8", Offset = "0x2A89EC8", VA = "0x2A89EC8")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x2A89ED4", Offset = "0x2A89ED4", VA = "0x2A89ED4")]
		public byte Add(FontStyles style)
		{
			return default;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x2A89FFC", Offset = "0x2A89FFC", VA = "0x2A89FFC")]
		public byte Remove(FontStyles style)
		{
			return default;
		}
	}
}
