using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000076")]
public class LeaderboardData : ScriptableObject
{
	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x18")]
	public new string name;

	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x20")]
	public string gamecenterId;

	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x28")]
	public string steamId;

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x15202EC", Offset = "0x15202EC", VA = "0x15202EC")]
	public string GetPlatformID(Store storeType)
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1520348", Offset = "0x1520348", VA = "0x1520348")]
	public LeaderboardData()
	{
	}
}
