using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007E1")]
public class MarioLevelController2D : GolfBall2DShooterBase
{
	[Token(Token = "0x40029FE")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public float minShootVelocity;

	[Token(Token = "0x40029FF")]
	[FieldOffset(Offset = "0x4C")]
	public float fullShootVelocity;

	[Token(Token = "0x4002A00")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public float pitch;

	[Token(Token = "0x4002A01")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	protected float spin;

	[Token(Token = "0x4002A02")]
	[FieldOffset(Offset = "0x58")]
	public Action OnLevelReset;

	[Token(Token = "0x4002A03")]
	[FieldOffset(Offset = "0x60")]
	public float KillAddForce;

	[Token(Token = "0x4002A04")]
	[FieldOffset(Offset = "0x68")]
	public Transform LookTransform;

	[Token(Token = "0x4002A05")]
	[FieldOffset(Offset = "0x70")]
	public float RotateSpeed;

	[Token(Token = "0x4002A06")]
	[FieldOffset(Offset = "0x74")]
	public LayerMask GroundLayer;

	[Token(Token = "0x4002A07")]
	[FieldOffset(Offset = "0x78")]
	public float GroundCheckDist;

	[Token(Token = "0x4002A08")]
	[FieldOffset(Offset = "0x7C")]
	public float HelperCheckDist;

	[Token(Token = "0x4002A09")]
	[FieldOffset(Offset = "0x80")]
	public float ExtraHorizontalForceTime;

	[Token(Token = "0x4002A0A")]
	[FieldOffset(Offset = "0x84")]
	public float HelperForce;

	[Token(Token = "0x4002A0B")]
	[FieldOffset(Offset = "0x88")]
	public bool BlockShootingInAir;

	[Token(Token = "0x4002A0C")]
	[FieldOffset(Offset = "0x90")]
	public ParticleSystem RunParticles;

	[Token(Token = "0x4002A0D")]
	[FieldOffset(Offset = "0x98")]
	public float SphereCastRadius;

	[Token(Token = "0x4002A0E")]
	[FieldOffset(Offset = "0xA0")]
	public Animator Animator;

	[Token(Token = "0x4002A0F")]
	[FieldOffset(Offset = "0xA8")]
	public Vector3 ExtraBoostDir;

	[Token(Token = "0x4002A10")]
	[FieldOffset(Offset = "0xB4")]
	public bool NoDragInAir;

	[Token(Token = "0x4002A11")]
	[FieldOffset(Offset = "0xB5")]
	public bool CanWallJump;

	[Token(Token = "0x4002A12")]
	[FieldOffset(Offset = "0xB8")]
	public LayerMask WallLayers;

	[Token(Token = "0x4002A13")]
	[FieldOffset(Offset = "0xBC")]
	public float ChangeDragSpeed;

	[Token(Token = "0x4002A14")]
	[FieldOffset(Offset = "0xC0")]
	public float wallDrag;

	[Token(Token = "0x4002A15")]
	[FieldOffset(Offset = "0xC4")]
	private bool resetting;

	[Token(Token = "0x4002A16")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 currentDirection;

	[Token(Token = "0x4002A17")]
	[FieldOffset(Offset = "0xD4")]
	private float applyForceTimer;

	[Token(Token = "0x4002A18")]
	[FieldOffset(Offset = "0xD8")]
	private float dragTarget;

	[Token(Token = "0x4002A19")]
	[FieldOffset(Offset = "0xDC")]
	private float origDrag;

	[Token(Token = "0x600242F")]
	[Address(RVA = "0x155D614", Offset = "0x155D614", VA = "0x155D614", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002430")]
	[Address(RVA = "0x155D664", Offset = "0x155D664", VA = "0x155D664", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002431")]
	[Address(RVA = "0x155DA00", Offset = "0x155DA00", VA = "0x155DA00", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002432")]
	[Address(RVA = "0x155D770", Offset = "0x155D770", VA = "0x155D770")]
	private void CheckIfNeedHelp(bool ignoreGrounded = false)
	{
	}

	[Token(Token = "0x6002433")]
	[Address(RVA = "0x155DD38", Offset = "0x155DD38", VA = "0x155DD38")]
	private bool IsGrounded()
	{
		return default;
	}

	[Token(Token = "0x6002434")]
	[Address(RVA = "0x155DFAC", Offset = "0x155DFAC", VA = "0x155DFAC")]
	private void OnCollisionEnter(Collision c)
	{
	}

	[Token(Token = "0x6002435")]
	[Address(RVA = "0x155E254", Offset = "0x155E254", VA = "0x155E254")]
	private void OnCollisionStay2D(Collision2D c)
	{
	}

	[Token(Token = "0x6002436")]
	[Address(RVA = "0x155E4C0", Offset = "0x155E4C0", VA = "0x155E4C0")]
	private void OnCollisionExit2D(Collision2D c)
	{
	}

	[Token(Token = "0x6002437")]
	[Address(RVA = "0x155E5EC", Offset = "0x155E5EC", VA = "0x155E5EC")]
	public void ForceOutOfBounds()
	{
	}

	[Token(Token = "0x6002438")]
	[Address(RVA = "0x155E5F0", Offset = "0x155E5F0", VA = "0x155E5F0")]
	public MarioLevelController2D()
	{
	}
}
