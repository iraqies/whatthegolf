using Il2CppDummyDll;

[Token(Token = "0x2000408")]
public class GrowFlowerChallenge : Challenge
{
	[Token(Token = "0x4001602")]
	[FieldOffset(Offset = "0xA8")]
	public FlowerGrow flower;

	[Token(Token = "0x4001603")]
	[FieldOffset(Offset = "0xB0")]
	public int flowerSteps;

	[Token(Token = "0x60012F4")]
	[Address(RVA = "0x14BDE8C", Offset = "0x14BDE8C", VA = "0x14BDE8C", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x14BDE90", Offset = "0x14BDE90", VA = "0x14BDE90")]
	private void Update()
	{
	}

	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x14BDEC0", Offset = "0x14BDEC0", VA = "0x14BDEC0")]
	public GrowFlowerChallenge()
	{
	}
}
