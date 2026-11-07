using Cinemachine;
using Il2CppDummyDll;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x20002E6")]
public class PuppetAutoController : UserControlThirdPerson
{
	[Token(Token = "0x4000FE5")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private CharacterPuppet Puppet;

	[Token(Token = "0x4000FE6")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private PuppetMaster PuppetMaster;

	[Token(Token = "0x4000FE7")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform Follower;

	[Token(Token = "0x4000FE8")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float FollowThreshold;

	[Token(Token = "0x4000FE9")]
	[FieldOffset(Offset = "0x68")]
	private CharacterAnimationThirdPerson characterAnimation;

	[Token(Token = "0x4000FEA")]
	[FieldOffset(Offset = "0x70")]
	private float dollySpeed;

	[Token(Token = "0x4000FEB")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private CinemachineDollyCart dolly;

	[Token(Token = "0x6000D53")]
	[Address(RVA = "0x1628FB8", Offset = "0x1628FB8", VA = "0x1628FB8", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000D54")]
	[Address(RVA = "0x16290FC", Offset = "0x16290FC", VA = "0x16290FC", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000D55")]
	[Address(RVA = "0x1629210", Offset = "0x1629210", VA = "0x1629210")]
	public PuppetAutoController()
	{
	}
}
