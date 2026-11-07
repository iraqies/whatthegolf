using System;
using Core;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20004C2")]
public class LevelDataAndChallenge
{
	[Token(Token = "0x40018EE")]
	[FieldOffset(Offset = "0x10")]
	public LevelData level;

	[Token(Token = "0x40018EF")]
	[FieldOffset(Offset = "0x18")]
	public string challengeID;

	[Token(Token = "0x60015F6")]
	[Address(RVA = "0x15292CC", Offset = "0x15292CC", VA = "0x15292CC")]
	public LevelDataAndChallenge()
	{
	}
}
