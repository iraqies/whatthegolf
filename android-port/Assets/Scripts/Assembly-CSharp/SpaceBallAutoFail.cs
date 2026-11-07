using Il2CppDummyDll;
using SpaceGolf;

[Token(Token = "0x200045F")]
public class SpaceBallAutoFail : AutoFailBase
{
	[Token(Token = "0x40017BA")]
	[FieldOffset(Offset = "0x2C")]
	public float velocityThreshold;

	[Token(Token = "0x40017BB")]
	[FieldOffset(Offset = "0x30")]
	public SpaceGolfBallShooter spaceball;

	[Token(Token = "0x6001471")]
	[Address(RVA = "0x16C14D0", Offset = "0x16C14D0", VA = "0x16C14D0", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6001472")]
	[Address(RVA = "0x16C15E8", Offset = "0x16C15E8", VA = "0x16C15E8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001473")]
	[Address(RVA = "0x16C16B0", Offset = "0x16C16B0", VA = "0x16C16B0")]
	public SpaceBallAutoFail()
	{
	}
}
