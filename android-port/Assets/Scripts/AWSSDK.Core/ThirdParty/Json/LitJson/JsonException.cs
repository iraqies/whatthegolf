using System;
using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x200001A")]
	public class JsonException : Exception
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1225EC4", Offset = "0x1225EC4", VA = "0x1225EC4")]
		public JsonException()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1225F40", Offset = "0x1225F40", VA = "0x1225F40")]
		internal JsonException(ParserToken token)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1226014", Offset = "0x1226014", VA = "0x1226014")]
		internal JsonException(ParserToken token, Exception inner_exception)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x12260F8", Offset = "0x12260F8", VA = "0x12260F8")]
		internal JsonException(int c)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x12261CC", Offset = "0x12261CC", VA = "0x12261CC")]
		internal JsonException(int c, Exception inner_exception)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x12262B0", Offset = "0x12262B0", VA = "0x12262B0")]
		public JsonException(string message)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x122633C", Offset = "0x122633C", VA = "0x122633C")]
		public JsonException(string message, Exception inner_exception)
		{
		}
	}
}
