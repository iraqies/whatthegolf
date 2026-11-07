using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000004")]
public class AchievementData : ScriptableObject
{
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x18")]
	public string gamecenterId;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x20")]
	public string playstationId;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x28")]
	public string steamId;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1403E50", Offset = "0x1403E50", VA = "0x1403E50")]
	public string GetPlatformID(Store storeType)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1403EC8", Offset = "0x1403EC8", VA = "0x1403EC8")]
	public AchievementData()
	{
	}
}
