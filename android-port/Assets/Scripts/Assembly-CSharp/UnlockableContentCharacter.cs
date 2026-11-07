using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000177")]
public class UnlockableContentCharacter : UnlockableContentPackage
{
	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x20")]
	public PlayerColors.AvatarIDs AvatarToUnlock;

	[Token(Token = "0x6000670")]
	[Address(RVA = "0x173C568", Offset = "0x173C568", VA = "0x173C568")]
	public UnlockableContentCharacter()
	{
	}
}
