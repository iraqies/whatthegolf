using Cinemachine;
using Il2CppDummyDll;
using RootMotion.Demos;

[Token(Token = "0x2000234")]
public class PuppetAutoRun : UserControlThirdPerson
{
	[Token(Token = "0x4000B47")]
	[FieldOffset(Offset = "0x48")]
	public CinemachineDollyCart FollowDolly;

	[Token(Token = "0x4000B48")]
	[FieldOffset(Offset = "0x50")]
	public CharacterPuppet Puppet;

	[Token(Token = "0x4000B49")]
	[FieldOffset(Offset = "0x58")]
	public float StartDelay;

	[Token(Token = "0x4000B4A")]
	[FieldOffset(Offset = "0x5C")]
	public bool AutoCorrectXOffset;

	[Token(Token = "0x60009E8")]
	[Address(RVA = "0x1629220", Offset = "0x1629220", VA = "0x1629220", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60009E9")]
	[Address(RVA = "0x1629434", Offset = "0x1629434", VA = "0x1629434")]
	public PuppetAutoRun()
	{
	}
}
