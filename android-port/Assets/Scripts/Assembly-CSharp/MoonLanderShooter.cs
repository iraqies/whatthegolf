using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007E6")]
public class MoonLanderShooter : ShooterBase
{
	[Token(Token = "0x4002A44")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float thrust;

	[Token(Token = "0x4002A45")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float horizontalThrustRatio;

	[Token(Token = "0x4002A46")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float engineLocation;

	[Token(Token = "0x4002A47")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Rigidbody2D rigidbody2D;

	[Token(Token = "0x4002A48")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioSource leftAudioSource;

	[Token(Token = "0x4002A49")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioSource rightAudioSource;

	[Token(Token = "0x4002A4A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform leftFlameTransform;

	[Token(Token = "0x4002A4B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform rightFlameTransform;

	[Token(Token = "0x4002A4C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AnimationCurve flameScaleCurve;

	[Token(Token = "0x4002A4D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private RandomAudioClips crashClips;

	[Token(Token = "0x4002A4E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Transform feetRoot;

	[Token(Token = "0x4002A4F")]
	[FieldOffset(Offset = "0x70")]
	private float left;

	[Token(Token = "0x4002A50")]
	[FieldOffset(Offset = "0x74")]
	private float right;

	[Token(Token = "0x4002A51")]
	[FieldOffset(Offset = "0x78")]
	private float left_target;

	[Token(Token = "0x4002A52")]
	[FieldOffset(Offset = "0x7C")]
	private float right_target;

	[Token(Token = "0x4002A53")]
	[FieldOffset(Offset = "0x80")]
	private float thrustChangeUp;

	[Token(Token = "0x4002A54")]
	[FieldOffset(Offset = "0x84")]
	private float thrustChangeDown;

	[Token(Token = "0x4002A55")]
	[FieldOffset(Offset = "0x88")]
	private float frameRotationRange;

	[Token(Token = "0x4002A56")]
	[FieldOffset(Offset = "0x8C")]
	private float thrustDuration;

	[Token(Token = "0x4002A57")]
	[FieldOffset(Offset = "0x90")]
	private float timer;

	[Token(Token = "0x4002A58")]
	[FieldOffset(Offset = "0x94")]
	private float minThrust;

	[Token(Token = "0x4002A59")]
	[FieldOffset(Offset = "0x98")]
	private float explosionForce;

	[Token(Token = "0x4002A5A")]
	[FieldOffset(Offset = "0xA0")]
	private Level level;

	[Token(Token = "0x600244C")]
	[Address(RVA = "0x156D210", Offset = "0x156D210", VA = "0x156D210")]
	private void Awake()
	{
	}

	[Token(Token = "0x600244D")]
	[Address(RVA = "0x156D278", Offset = "0x156D278", VA = "0x156D278", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600244E")]
	[Address(RVA = "0x156D408", Offset = "0x156D408", VA = "0x156D408")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x600244F")]
	[Address(RVA = "0x156D734", Offset = "0x156D734", VA = "0x156D734")]
	private void Update()
	{
	}

	[Token(Token = "0x6002450")]
	[Address(RVA = "0x156D848", Offset = "0x156D848", VA = "0x156D848")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002451")]
	[Address(RVA = "0x156DA1C", Offset = "0x156DA1C", VA = "0x156DA1C")]
	private void Crash()
	{
	}

	[Token(Token = "0x6002452")]
	[Address(RVA = "0x156DA88", Offset = "0x156DA88", VA = "0x156DA88")]
	public MoonLanderShooter()
	{
	}
}
