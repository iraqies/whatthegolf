using System.Collections.Generic;
using Core;
using Il2CppDummyDll;

[Token(Token = "0x2000417")]
public class PortAllChallenge : Challenge
{
	[Token(Token = "0x4001661")]
	[FieldOffset(Offset = "0xA1")]
	public bool passThroughOnceOnly;

	[Token(Token = "0x4001662")]
	[FieldOffset(Offset = "0xA2")]
	public bool allInOne;

	[Token(Token = "0x4001663")]
	[FieldOffset(Offset = "0xA8")]
	public List<SimplePortal> Portals;

	[Token(Token = "0x4001664")]
	[FieldOffset(Offset = "0xB0")]
	private GolfBallController golfBallController;

	[Token(Token = "0x4001665")]
	[FieldOffset(Offset = "0xB8")]
	private FlagAudio flagAudio;

	[Token(Token = "0x6001342")]
	[Address(RVA = "0x161AD7C", Offset = "0x161AD7C", VA = "0x161AD7C", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001343")]
	[Address(RVA = "0x161AF88", Offset = "0x161AF88", VA = "0x161AF88", Slot = "9")]
	protected override void ChallengeUpdate()
	{
	}

	[Token(Token = "0x6001344")]
	[Address(RVA = "0x161B1FC", Offset = "0x161B1FC", VA = "0x161B1FC", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x6001345")]
	[Address(RVA = "0x161B4A4", Offset = "0x161B4A4", VA = "0x161B4A4")]
	public PortAllChallenge()
	{
	}
}
