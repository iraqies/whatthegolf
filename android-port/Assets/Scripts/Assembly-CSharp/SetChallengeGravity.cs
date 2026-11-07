using Il2CppDummyDll;

[Token(Token = "0x2000444")]
public class SetChallengeGravity : ChallengeInitializeBase
{
	[Token(Token = "0x4001744")]
	[FieldOffset(Offset = "0x18")]
	public Gravity gravity;

	[Token(Token = "0x6001406")]
	[Address(RVA = "0x168C794", Offset = "0x168C794", VA = "0x168C794", Slot = "4")]
	public override void InitOnActivate()
	{
	}

	[Token(Token = "0x6001407")]
	[Address(RVA = "0x168C7B0", Offset = "0x168C7B0", VA = "0x168C7B0")]
	public SetChallengeGravity()
	{
	}
}
