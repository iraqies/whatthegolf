using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200040B")]
public class KingOfTheHillChallenge : Challenge
{
	[Token(Token = "0x4001612")]
	[FieldOffset(Offset = "0xA8")]
	public List<ChallengeAIRoller> enemies;

	[Token(Token = "0x6001301")]
	[Address(RVA = "0x1501764", Offset = "0x1501764", VA = "0x1501764", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001302")]
	[Address(RVA = "0x15019E0", Offset = "0x15019E0", VA = "0x15019E0")]
	private void OnOnOutOfBounds(OutOfBoundsTrigger obj)
	{
	}

	[Token(Token = "0x6001303")]
	[Address(RVA = "0x1501B48", Offset = "0x1501B48", VA = "0x1501B48")]
	public KingOfTheHillChallenge()
	{
	}
}
