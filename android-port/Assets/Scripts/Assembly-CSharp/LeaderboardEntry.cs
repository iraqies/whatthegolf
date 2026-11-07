using Il2CppDummyDll;

[Token(Token = "0x20008C7")]
public class LeaderboardEntry
{
	[Token(Token = "0x400301F")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4003020")]
	[FieldOffset(Offset = "0x18")]
	public bool isPlayer;

	[Token(Token = "0x4003021")]
	[FieldOffset(Offset = "0x1C")]
	public int score;

	[Token(Token = "0x4003022")]
	[FieldOffset(Offset = "0x20")]
	public int position;

	[Token(Token = "0x6002882")]
	[Address(RVA = "0x1520350", Offset = "0x1520350", VA = "0x1520350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002883")]
	[Address(RVA = "0x1520564", Offset = "0x1520564", VA = "0x1520564")]
	public LeaderboardEntry()
	{
	}
}
