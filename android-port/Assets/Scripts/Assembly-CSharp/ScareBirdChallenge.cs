using Audio;
using Core;
using Il2CppDummyDll;

[Token(Token = "0x200041B")]
public class ScareBirdChallenge : Challenge
{
	[Token(Token = "0x4001671")]
	[FieldOffset(Offset = "0xA1")]
	public bool GolfToFlagAfter;

	[Token(Token = "0x4001672")]
	[FieldOffset(Offset = "0xA4")]
	public float CustomScareTriggerRange;

	[Token(Token = "0x4001673")]
	[FieldOffset(Offset = "0xA8")]
	private BirdNPC[] scareBirds;

	[Token(Token = "0x4001674")]
	[FieldOffset(Offset = "0xB0")]
	private int scareCount;

	[Token(Token = "0x4001675")]
	[FieldOffset(Offset = "0xB8")]
	private GolfBallController controller;

	[Token(Token = "0x4001676")]
	[FieldOffset(Offset = "0xC0")]
	private TiltChallengeSFX SFX;

	[Token(Token = "0x6001351")]
	[Address(RVA = "0x167AB04", Offset = "0x167AB04", VA = "0x167AB04", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001352")]
	[Address(RVA = "0x167ADDC", Offset = "0x167ADDC", VA = "0x167ADDC")]
	private void OnBirdScared(BirdNPC bird)
	{
	}

	[Token(Token = "0x6001353")]
	[Address(RVA = "0x167AEF0", Offset = "0x167AEF0", VA = "0x167AEF0", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x6001354")]
	[Address(RVA = "0x167AF24", Offset = "0x167AF24", VA = "0x167AF24", Slot = "5")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001355")]
	[Address(RVA = "0x167AFF4", Offset = "0x167AFF4", VA = "0x167AFF4", Slot = "6")]
	public override string GetWinMessageID()
	{
		return null;
	}

	[Token(Token = "0x6001356")]
	[Address(RVA = "0x167B058", Offset = "0x167B058", VA = "0x167B058")]
	public ScareBirdChallenge()
	{
	}
}
