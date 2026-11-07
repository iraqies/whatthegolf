using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007CF")]
public class BouncyboyShooter : GolfBall2DShooterBase
{
	[Serializable]
	[Token(Token = "0x20007D0")]
	public class Leg
	{
		[Token(Token = "0x4002962")]
		[FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4002963")]
		[FieldOffset(Offset = "0x18")]
		public float rotationDirection;

		[Token(Token = "0x60023C7")]
		[Address(RVA = "0x177B208", Offset = "0x177B208", VA = "0x177B208")]
		public Leg()
		{
		}
	}

	[Token(Token = "0x4002951")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float minShootVelocity;

	[Token(Token = "0x4002952")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float fullShootVelocity;

	[Token(Token = "0x4002953")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float upwardsForceRatio;

	[Token(Token = "0x4002954")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float MaxVelocity;

	[Token(Token = "0x4002955")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float MinVerticalVelocity;

	[Token(Token = "0x4002956")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float BounceRatio;

	[Token(Token = "0x4002957")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private CircleCollider2D feetCollider;

	[Token(Token = "0x4002958")]
	[FieldOffset(Offset = "0x68")]
	public Transform LookTransform;

	[Token(Token = "0x4002959")]
	[FieldOffset(Offset = "0x70")]
	public float RotateSpeed;

	[Token(Token = "0x400295A")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float maxLegAngle;

	[Token(Token = "0x400295B")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private AnimationCurve verticalSpeedToLegAngle;

	[Token(Token = "0x400295C")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Leg[] legs;

	[Token(Token = "0x400295D")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private AudioClip bounceAudioClip;

	[Token(Token = "0x400295E")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 currentDirection;

	[Token(Token = "0x400295F")]
	[FieldOffset(Offset = "0x9C")]
	private bool hasHitGround;

	[Token(Token = "0x4002960")]
	[FieldOffset(Offset = "0xA0")]
	private LayerMask groundLayer;

	[Token(Token = "0x4002961")]
	[FieldOffset(Offset = "0xA4")]
	private Vector2 lastVelocity;

	[Token(Token = "0x60023C2")]
	[Address(RVA = "0x1702390", Offset = "0x1702390", VA = "0x1702390", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60023C3")]
	[Address(RVA = "0x1702408", Offset = "0x1702408", VA = "0x1702408", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60023C4")]
	[Address(RVA = "0x170270C", Offset = "0x170270C", VA = "0x170270C", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60023C5")]
	[Address(RVA = "0x1702A8C", Offset = "0x1702A8C", VA = "0x1702A8C")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60023C6")]
	[Address(RVA = "0x1702C68", Offset = "0x1702C68", VA = "0x1702C68")]
	public BouncyboyShooter()
	{
	}
}
