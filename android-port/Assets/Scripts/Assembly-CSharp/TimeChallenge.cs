using Audio;
using Core;
using Il2CppDummyDll;

[Token(Token = "0x2000425")]
public class TimeChallenge : Challenge
{
	[Token(Token = "0x2000426")]
	private enum TimeState
	{
		[Token(Token = "0x40016B7")]
		PrePlayCountdown = 0,
		[Token(Token = "0x40016B8")]
		CountingDown = 1
	}

	[Token(Token = "0x40016AC")]
	[FieldOffset(Offset = "0xA4")]
	public int TimeToBeat;

	[Token(Token = "0x40016AD")]
	[FieldOffset(Offset = "0xA8")]
	public int PreplayCountdownTime;

	[Token(Token = "0x40016AE")]
	[FieldOffset(Offset = "0xAC")]
	private float timer;

	[Token(Token = "0x40016AF")]
	[FieldOffset(Offset = "0xB0")]
	public GolfBallController controller;

	[Token(Token = "0x40016B0")]
	[FieldOffset(Offset = "0xB8")]
	private int lastSecond;

	[Token(Token = "0x40016B1")]
	[FieldOffset(Offset = "0xBC")]
	private bool isActive;

	[Token(Token = "0x40016B2")]
	[FieldOffset(Offset = "0xC0")]
	private TimeState currentState;

	[Token(Token = "0x40016B3")]
	[FieldOffset(Offset = "0xC8")]
	private StopwatchSFX stopwatchSFX;

	[Token(Token = "0x40016B4")]
	[FieldOffset(Offset = "0xD0")]
	public bool winOnTimeOut;

	[Token(Token = "0x40016B5")]
	[FieldOffset(Offset = "0xD4")]
	private int currentTimeToBeat;

	[Token(Token = "0x600137A")]
	[Address(RVA = "0x1714770", Offset = "0x1714770", VA = "0x1714770", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x600137B")]
	[Address(RVA = "0x17149A0", Offset = "0x17149A0", VA = "0x17149A0", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x600137C")]
	[Address(RVA = "0x1714A44", Offset = "0x1714A44", VA = "0x1714A44", Slot = "11")]
	public override void OnFail()
	{
	}

	[Token(Token = "0x600137D")]
	[Address(RVA = "0x1714AF4", Offset = "0x1714AF4", VA = "0x1714AF4", Slot = "9")]
	protected override void ChallengeUpdate()
	{
	}

	[Token(Token = "0x600137E")]
	[Address(RVA = "0x1714D90", Offset = "0x1714D90", VA = "0x1714D90", Slot = "5")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x600137F")]
	[Address(RVA = "0x1714F38", Offset = "0x1714F38", VA = "0x1714F38", Slot = "6")]
	public override string GetWinMessageID()
	{
		return null;
	}

	[Token(Token = "0x6001380")]
	[Address(RVA = "0x1714F9C", Offset = "0x1714F9C", VA = "0x1714F9C")]
	public TimeChallenge()
	{
	}
}
