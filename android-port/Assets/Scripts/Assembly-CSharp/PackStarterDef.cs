using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200051F")]
public class PackStarterDef
{
	[Token(Token = "0x4001A6D")]
	[FieldOffset(Offset = "0x10")]
	public List<string> contentPackIds;

	[Token(Token = "0x4001A6E")]
	[FieldOffset(Offset = "0x18")]
	public BasePackStarter starter;

	[Token(Token = "0x4001A6F")]
	[FieldOffset(Offset = "0x20")]
	public bool isLevelNotificationStarter;

	[Token(Token = "0x6001768")]
	[Address(RVA = "0x15D4A64", Offset = "0x15D4A64", VA = "0x15D4A64")]
	public PackStarterDef()
	{
	}
}
