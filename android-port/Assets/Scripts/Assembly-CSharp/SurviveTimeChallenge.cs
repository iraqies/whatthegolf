using Core;
using Il2CppDummyDll;

[Token(Token = "0x2000420")]
public class SurviveTimeChallenge : Challenge
{
	[Token(Token = "0x2000421")]
	private enum TimeState
	{
		[Token(Token = "0x4001695")]
		PrePlayCountdown = 0,
		[Token(Token = "0x4001696")]
		CountingDown = 1
	}

	[Token(Token = "0x400168D")]
	[FieldOffset(Offset = "0xA4")]
	public int TimeToSurvive;

	[Token(Token = "0x400168E")]
	[FieldOffset(Offset = "0xA8")]
	public int PreplayCountdownTime;

	[Token(Token = "0x400168F")]
	[FieldOffset(Offset = "0xAC")]
	private float timer;

	[Token(Token = "0x4001690")]
	[FieldOffset(Offset = "0xB0")]
	public GolfBallController controller;

	[Token(Token = "0x4001691")]
	[FieldOffset(Offset = "0xB8")]
	private int lastSecond;

	[Token(Token = "0x4001692")]
	[FieldOffset(Offset = "0xBC")]
	private bool isActive;

	[Token(Token = "0x4001693")]
	[FieldOffset(Offset = "0xC0")]
	private TimeState currentState;

	[Token(Token = "0x6001369")]
	[Address(RVA = "0x16EF14C", Offset = "0x16EF14C", VA = "0x16EF14C", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x600136A")]
	[Address(RVA = "0x16EF2B4", Offset = "0x16EF2B4", VA = "0x16EF2B4", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x600136B")]
	[Address(RVA = "0x16EF2C0", Offset = "0x16EF2C0", VA = "0x16EF2C0", Slot = "5")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x600136C")]
	[Address(RVA = "0x16EF3F4", Offset = "0x16EF3F4", VA = "0x16EF3F4", Slot = "9")]
	protected override void ChallengeUpdate()
	{
	}

	[Token(Token = "0x600136D")]
	[Address(RVA = "0x16EF574", Offset = "0x16EF574", VA = "0x16EF574")]
	public SurviveTimeChallenge()
	{
	}
}
