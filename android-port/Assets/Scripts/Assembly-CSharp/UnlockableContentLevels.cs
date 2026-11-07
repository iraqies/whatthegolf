using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000178")]
public class UnlockableContentLevels : UnlockableContentPackage
{
	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x20")]
	public LevelDataContainer LevelsToUnlock;

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x173C578", Offset = "0x173C578", VA = "0x173C578")]
	public UnlockableContentLevels()
	{
	}
}
