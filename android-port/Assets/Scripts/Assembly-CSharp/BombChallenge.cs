using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000404")]
public class BombChallenge : Challenge
{
	[Token(Token = "0x40015EE")]
	[FieldOffset(Offset = "0xA8")]
	private BombChallengeTarget[] _targets;

	[Token(Token = "0x40015EF")]
	[FieldOffset(Offset = "0xB0")]
	private List<BombChallengeTarget> _bombedTargets;

	[Token(Token = "0x40015F0")]
	[FieldOffset(Offset = "0xB8")]
	public int targetsToWin;

	[Token(Token = "0x60012E4")]
	[Address(RVA = "0x1617A3C", Offset = "0x1617A3C", VA = "0x1617A3C", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x60012E5")]
	[Address(RVA = "0x1617BF4", Offset = "0x1617BF4", VA = "0x1617BF4")]
	private void OnBombed(BombChallengeTarget target)
	{
	}

	[Token(Token = "0x60012E6")]
	[Address(RVA = "0x1617D08", Offset = "0x1617D08", VA = "0x1617D08")]
	public BombChallenge()
	{
	}
}
