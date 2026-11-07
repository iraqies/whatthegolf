using Audio;
using Core;
using Il2CppDummyDll;
using RootMotion.Demos;
using UnityEngine;

[Token(Token = "0x2000261")]
public class PuppetCarLikeController : UserControlThirdPerson
{
	[Token(Token = "0x4000C55")]
	[FieldOffset(Offset = "0x48")]
	public GolfBallController Controller;

	[Token(Token = "0x4000C56")]
	[FieldOffset(Offset = "0x50")]
	public CharacterPuppet Puppet;

	[Token(Token = "0x4000C57")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve AnimSpeedMultiplierCurve;

	[Token(Token = "0x4000C58")]
	[FieldOffset(Offset = "0x60")]
	public ClipSettingsCollection ShootClip;

	[Token(Token = "0x4000C59")]
	[FieldOffset(Offset = "0x68")]
	protected CharacterAnimationThirdPerson characterAnimation;

	[Token(Token = "0x4000C5A")]
	[FieldOffset(Offset = "0x70")]
	protected Vector3 aimDir;

	[Token(Token = "0x4000C5B")]
	[FieldOffset(Offset = "0x7C")]
	protected Vector3 moveDir;

	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0x162943C", Offset = "0x162943C", VA = "0x162943C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0x16295BC", Offset = "0x16295BC", VA = "0x16295BC", Slot = "6")]
	public virtual void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000AB7")]
	[Address(RVA = "0x1629630", Offset = "0x1629630", VA = "0x1629630")]
	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000AB8")]
	[Address(RVA = "0x162966C", Offset = "0x162966C", VA = "0x162966C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000AB9")]
	[Address(RVA = "0x16298F8", Offset = "0x16298F8", VA = "0x16298F8")]
	public PuppetCarLikeController()
	{
	}
}
