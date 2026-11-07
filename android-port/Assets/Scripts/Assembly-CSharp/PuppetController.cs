using Audio;
using Core;
using Il2CppDummyDll;
using RootMotion.Demos;
using UnityEngine;

[Token(Token = "0x20001C6")]
public class PuppetController : UserControlThirdPerson
{
	[Token(Token = "0x4000802")]
	[FieldOffset(Offset = "0x48")]
	public bool CanJump;

	[Token(Token = "0x4000803")]
	[FieldOffset(Offset = "0x50")]
	public GolfBallController Controller;

	[Token(Token = "0x4000804")]
	[FieldOffset(Offset = "0x58")]
	public float JumpTime;

	[Token(Token = "0x4000805")]
	[FieldOffset(Offset = "0x60")]
	public CharacterPuppet Puppet;

	[Token(Token = "0x4000806")]
	[FieldOffset(Offset = "0x68")]
	public float BlockTime;

	[Token(Token = "0x4000807")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve AnimSpeedMultiplierCurve;

	[Token(Token = "0x4000808")]
	[FieldOffset(Offset = "0x78")]
	public ClipSettingsCollection ShootClip;

	[Token(Token = "0x4000809")]
	[FieldOffset(Offset = "0x80")]
	private CharacterAnimationThirdPerson characterAnimation;

	[Token(Token = "0x400080A")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 aimDir;

	[Token(Token = "0x400080B")]
	[FieldOffset(Offset = "0x94")]
	private float jumpTimer;

	[Token(Token = "0x400080C")]
	[FieldOffset(Offset = "0x98")]
	private float blockTimer;

	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x1629900", Offset = "0x1629900", VA = "0x1629900", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x1629A8C", Offset = "0x1629A8C", VA = "0x1629A8C")]
	public void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x1629B44", Offset = "0x1629B44", VA = "0x1629B44")]
	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x1629B98", Offset = "0x1629B98", VA = "0x1629B98", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x1629E68", Offset = "0x1629E68", VA = "0x1629E68")]
	public PuppetController()
	{
	}
}
