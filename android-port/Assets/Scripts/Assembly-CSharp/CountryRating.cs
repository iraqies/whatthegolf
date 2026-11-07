using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000B40")]
public struct CountryRating
{
	[Token(Token = "0x4003EAE")]
	[FieldOffset(Offset = "0x0")]
	public string code;

	[Token(Token = "0x4003EAF")]
	[FieldOffset(Offset = "0x8")]
	public string country;

	[Token(Token = "0x4003EB0")]
	[FieldOffset(Offset = "0x10")]
	public int level;
}
