using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000B69")]
public class Morse
{
	[Token(Token = "0x4003F51")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<char, string> morse;

	[Token(Token = "0x4003F52")]
	[FieldOffset(Offset = "0x8")]
	private static bool didInit;

	[Token(Token = "0x60036CC")]
	[Address(RVA = "0x156F9B4", Offset = "0x156F9B4", VA = "0x156F9B4")]
	public static void Init()
	{
	}

	[Token(Token = "0x60036CD")]
	[Address(RVA = "0x1570250", Offset = "0x1570250", VA = "0x1570250")]
	public static string ToMorse(string text)
	{
		return null;
	}
}
