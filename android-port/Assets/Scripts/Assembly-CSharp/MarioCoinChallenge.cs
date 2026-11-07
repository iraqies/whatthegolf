using System.Collections.Generic;
using Core;
using Il2CppDummyDll;

[Token(Token = "0x200040C")]
public class MarioCoinChallenge : Challenge
{
	[Token(Token = "0x4001613")]
	[FieldOffset(Offset = "0xA8")]
	public List<MarioBreakableBlock> coinBlocks;

	[Token(Token = "0x4001614")]
	[FieldOffset(Offset = "0xB0")]
	private int hitAmount;

	[Token(Token = "0x4001615")]
	[FieldOffset(Offset = "0xB4")]
	private int maxHitAmount;

	[Token(Token = "0x4001616")]
	[FieldOffset(Offset = "0xB8")]
	private GolfBallController controller;

	[Token(Token = "0x6001304")]
	[Address(RVA = "0x155B6D0", Offset = "0x155B6D0", VA = "0x155B6D0", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001305")]
	[Address(RVA = "0x155B8DC", Offset = "0x155B8DC", VA = "0x155B8DC")]
	private void OnBlockHit(MarioBreakableBlock block)
	{
	}

	[Token(Token = "0x6001306")]
	[Address(RVA = "0x155B980", Offset = "0x155B980", VA = "0x155B980")]
	public MarioCoinChallenge()
	{
	}
}
