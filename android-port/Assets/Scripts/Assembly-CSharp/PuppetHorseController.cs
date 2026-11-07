using Audio;
using Core;
using Il2CppDummyDll;
using RootMotion.Demos;
using UnityEngine;

[Token(Token = "0x2000229")]
public class PuppetHorseController : UserControlThirdPerson
{
	[Token(Token = "0x4000AFA")]
	[FieldOffset(Offset = "0x48")]
	public GolfBallController Controller;

	[Token(Token = "0x4000AFB")]
	[FieldOffset(Offset = "0x50")]
	public CharacterPuppet Puppet;

	[Token(Token = "0x4000AFC")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve AnimSpeedMultiplierCurve;

	[Token(Token = "0x4000AFD")]
	[FieldOffset(Offset = "0x60")]
	public CharacterAnimationSimple animController;

	[Token(Token = "0x4000AFE")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public float pitch;

	[Token(Token = "0x4000AFF")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public AnimationCurve powerToPitchWeightCurve;

	[Token(Token = "0x4000B00")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public float spin;

	[Token(Token = "0x4000B01")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public float jumpMinForce;

	[Token(Token = "0x4000B02")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public float jumpMaxForce;

	[Token(Token = "0x4000B03")]
	[FieldOffset(Offset = "0x84")]
	private float jumpStartTime;

	[Token(Token = "0x4000B04")]
	[FieldOffset(Offset = "0x88")]
	private Rigidbody rb;

	[Token(Token = "0x4000B05")]
	[FieldOffset(Offset = "0x90")]
	public ClipSettingsCollection ShootClip;

	[Token(Token = "0x4000B06")]
	[FieldOffset(Offset = "0x98")]
	private CharacterAnimationThirdPerson characterAnimation;

	[Token(Token = "0x4000B07")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 aimDir;

	[Token(Token = "0x4000B08")]
	[FieldOffset(Offset = "0xAC")]
	private Vector3 moveDir;

	[Token(Token = "0x60009BD")]
	[Address(RVA = "0x162BB88", Offset = "0x162BB88", VA = "0x162BB88", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60009BE")]
	[Address(RVA = "0x162BD38", Offset = "0x162BD38", VA = "0x162BD38")]
	public void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60009BF")]
	[Address(RVA = "0x162BE00", Offset = "0x162BE00", VA = "0x162BE00")]
	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60009C0")]
	[Address(RVA = "0x162BE3C", Offset = "0x162BE3C", VA = "0x162BE3C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x162C0F0", Offset = "0x162C0F0", VA = "0x162C0F0")]
	public PuppetHorseController()
	{
	}
}
