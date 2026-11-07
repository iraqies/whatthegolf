using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200002A")]
	public enum JsonToken
	{
		[Token(Token = "0x40000E0")]
		None = 0,
		[Token(Token = "0x40000E1")]
		StartObject = 1,
		[Token(Token = "0x40000E2")]
		StartArray = 2,
		[Token(Token = "0x40000E3")]
		StartConstructor = 3,
		[Token(Token = "0x40000E4")]
		PropertyName = 4,
		[Token(Token = "0x40000E5")]
		Comment = 5,
		[Token(Token = "0x40000E6")]
		Raw = 6,
		[Token(Token = "0x40000E7")]
		Integer = 7,
		[Token(Token = "0x40000E8")]
		Float = 8,
		[Token(Token = "0x40000E9")]
		String = 9,
		[Token(Token = "0x40000EA")]
		Boolean = 10,
		[Token(Token = "0x40000EB")]
		Null = 11,
		[Token(Token = "0x40000EC")]
		Undefined = 12,
		[Token(Token = "0x40000ED")]
		EndObject = 13,
		[Token(Token = "0x40000EE")]
		EndArray = 14,
		[Token(Token = "0x40000EF")]
		EndConstructor = 15,
		[Token(Token = "0x40000F0")]
		Date = 16,
		[Token(Token = "0x40000F1")]
		Bytes = 17
	}
}
