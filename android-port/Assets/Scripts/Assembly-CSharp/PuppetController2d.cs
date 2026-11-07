using Audio;
using Core;
using Il2CppDummyDll;
using RootMotion.Demos;
using UnityEngine;

[Token(Token = "0x2000230")]
public class PuppetController2d : UserControlThirdPerson
{
	[Token(Token = "0x4000B24")]
	[FieldOffset(Offset = "0x48")]
	public bool CanJump;

	[Token(Token = "0x4000B25")]
	[FieldOffset(Offset = "0x50")]
	public GolfBallController Controller;

	[Token(Token = "0x4000B26")]
	[FieldOffset(Offset = "0x58")]
	public float JumpTime;

	[Token(Token = "0x4000B27")]
	[FieldOffset(Offset = "0x60")]
	public CharacterPuppet Puppet;

	[Token(Token = "0x4000B28")]
	[FieldOffset(Offset = "0x68")]
	public float BlockTime;

	[Token(Token = "0x4000B29")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve AnimSpeedMultiplierCurve;

	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0x78")]
	public ClipSettingsCollection ShootClip;

	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0x80")]
	private CharacterAnimationThirdPerson characterAnimation;

	[Token(Token = "0x4000B2C")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 aimDir;

	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x94")]
	private float jumpTimer;

	[Token(Token = "0x4000B2E")]
	[FieldOffset(Offset = "0x98")]
	private float blockTimer;

	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x9C")]
	public float allowedZVariance;

	[Token(Token = "0x4000B30")]
	[FieldOffset(Offset = "0xA0")]
	public float zCorrectionSpeed;

	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0xA4")]
	private float originZ;

	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x1629E80", Offset = "0x1629E80", VA = "0x1629E80", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x162A028", Offset = "0x162A028", VA = "0x162A028")]
	public void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x162A0E0", Offset = "0x162A0E0", VA = "0x162A0E0")]
	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x162A134", Offset = "0x162A134", VA = "0x162A134", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x162A454", Offset = "0x162A454", VA = "0x162A454")]
	public PuppetController2d()
	{
	}
}
