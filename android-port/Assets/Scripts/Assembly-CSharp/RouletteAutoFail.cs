using Core;
using Il2CppDummyDll;

[Token(Token = "0x200045E")]
public class RouletteAutoFail : AutoFailBase
{
	[Token(Token = "0x40017B8")]
	[FieldOffset(Offset = "0x30")]
	public GolfBallShooterBase rouletteShooter;

	[Token(Token = "0x40017B9")]
	[FieldOffset(Offset = "0x38")]
	public float velocityThreshold;

	[Token(Token = "0x600146F")]
	[Address(RVA = "0x16618FC", Offset = "0x16618FC", VA = "0x16618FC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001470")]
	[Address(RVA = "0x1661A24", Offset = "0x1661A24", VA = "0x1661A24")]
	public RouletteAutoFail()
	{
	}
}
