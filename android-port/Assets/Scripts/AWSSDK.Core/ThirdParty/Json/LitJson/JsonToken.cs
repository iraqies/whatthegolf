using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x2000028")]
	public enum JsonToken
	{
		[Token(Token = "0x4000079")]
		None = 0,
		[Token(Token = "0x400007A")]
		ObjectStart = 1,
		[Token(Token = "0x400007B")]
		PropertyName = 2,
		[Token(Token = "0x400007C")]
		ObjectEnd = 3,
		[Token(Token = "0x400007D")]
		ArrayStart = 4,
		[Token(Token = "0x400007E")]
		ArrayEnd = 5,
		[Token(Token = "0x400007F")]
		Int = 6,
		[Token(Token = "0x4000080")]
		UInt = 7,
		[Token(Token = "0x4000081")]
		Long = 8,
		[Token(Token = "0x4000082")]
		ULong = 9,
		[Token(Token = "0x4000083")]
		Double = 10,
		[Token(Token = "0x4000084")]
		String = 11,
		[Token(Token = "0x4000085")]
		Boolean = 12,
		[Token(Token = "0x4000086")]
		Null = 13
	}
}
