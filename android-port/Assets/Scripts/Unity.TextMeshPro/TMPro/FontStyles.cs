using System;
using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x2000064")]
	[Flags]
	public enum FontStyles
	{
		[Token(Token = "0x400035C")]
		Normal = 0,
		[Token(Token = "0x400035D")]
		Bold = 1,
		[Token(Token = "0x400035E")]
		Italic = 2,
		[Token(Token = "0x400035F")]
		Underline = 4,
		[Token(Token = "0x4000360")]
		LowerCase = 8,
		[Token(Token = "0x4000361")]
		UpperCase = 0x10,
		[Token(Token = "0x4000362")]
		SmallCaps = 0x20,
		[Token(Token = "0x4000363")]
		Strikethrough = 0x40,
		[Token(Token = "0x4000364")]
		Superscript = 0x80,
		[Token(Token = "0x4000365")]
		Subscript = 0x100,
		[Token(Token = "0x4000366")]
		Highlight = 0x200
	}
}
