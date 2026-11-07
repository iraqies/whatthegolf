using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007E0")]
public class MarioLevelController : GolfBallShooterBase
{
	[Token(Token = "0x40029E0")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public float fullShootVelocity;

	[Token(Token = "0x40029E1")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	public float pitch;

	[Token(Token = "0x40029E2")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected float spin;

	[Token(Token = "0x40029E3")]
	[FieldOffset(Offset = "0x70")]
	public Action OnLevelReset;

	[Token(Token = "0x40029E4")]
	[FieldOffset(Offset = "0x78")]
	public float KillAddForce;

	[Token(Token = "0x40029E5")]
	[FieldOffset(Offset = "0x80")]
	public Transform LookTransform;

	[Token(Token = "0x40029E6")]
	[FieldOffset(Offset = "0x88")]
	public float RotateSpeed;

	[Token(Token = "0x40029E7")]
	[FieldOffset(Offset = "0x8C")]
	public LayerMask GroundLayer;

	[Token(Token = "0x40029E8")]
	[FieldOffset(Offset = "0x90")]
	public float GroundCheckDist;

	[Token(Token = "0x40029E9")]
	[FieldOffset(Offset = "0x94")]
	public float HelperCheckDist;

	[Token(Token = "0x40029EA")]
	[FieldOffset(Offset = "0x98")]
	public float ExtraHorizontalForceTime;

	[Token(Token = "0x40029EB")]
	[FieldOffset(Offset = "0x9C")]
	public float HelperForce;

	[Token(Token = "0x40029EC")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 Up;

	[Token(Token = "0x40029ED")]
	[FieldOffset(Offset = "0xAC")]
	public bool BlockShootingInAir;

	[Token(Token = "0x40029EE")]
	[FieldOffset(Offset = "0xB0")]
	public ParticleSystem RunParticles;

	[Token(Token = "0x40029EF")]
	[FieldOffset(Offset = "0xB8")]
	public float SphereCastRadius;

	[Token(Token = "0x40029F0")]
	[FieldOffset(Offset = "0xC0")]
	public Animator Animator;

	[Token(Token = "0x40029F1")]
	[FieldOffset(Offset = "0xC8")]
	public Vector3 ExtraBoostDir;

	[Token(Token = "0x40029F2")]
	[FieldOffset(Offset = "0xD4")]
	public bool CanWallJump;

	[Token(Token = "0x40029F3")]
	[FieldOffset(Offset = "0xD8")]
	public LayerMask WallLayers;

	[Token(Token = "0x40029F4")]
	[FieldOffset(Offset = "0xDC")]
	public float ChangeDragSpeed;

	[Token(Token = "0x40029F5")]
	[FieldOffset(Offset = "0xE0")]
	public float wallDrag;

	[Token(Token = "0x40029F6")]
	[FieldOffset(Offset = "0xE4")]
	public bool useWalkingHelper;

	[Token(Token = "0x40029F7")]
	[FieldOffset(Offset = "0xE5")]
	private bool resetting;

	[Token(Token = "0x40029F8")]
	[FieldOffset(Offset = "0xE8")]
	private Vector3 currentDirection;

	[Token(Token = "0x40029F9")]
	[FieldOffset(Offset = "0xF4")]
	private float applyForceTimer;

	[Token(Token = "0x40029FA")]
	[FieldOffset(Offset = "0xF8")]
	private float dragTarget;

	[Token(Token = "0x40029FB")]
	[FieldOffset(Offset = "0xFC")]
	private float origDrag;

	[Token(Token = "0x40029FC")]
	[FieldOffset(Offset = "0x100")]
	private Vector3 lastFrameVelocity;

	[Token(Token = "0x40029FD")]
	[FieldOffset(Offset = "0x10C")]
	private float forcingGroundedFor;

	[Token(Token = "0x6002423")]
	[Address(RVA = "0x155C5DC", Offset = "0x155C5DC", VA = "0x155C5DC", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002424")]
	[Address(RVA = "0x155C62C", Offset = "0x155C62C", VA = "0x155C62C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002425")]
	[Address(RVA = "0x155CBD4", Offset = "0x155CBD4", VA = "0x155CBD4", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002426")]
	[Address(RVA = "0x155C7B8", Offset = "0x155C7B8", VA = "0x155C7B8")]
	private void CheckIfNeedHelp(bool ignoreGrounded = false)
	{
	}

	[Token(Token = "0x6002427")]
	[Address(RVA = "0x155CF08", Offset = "0x155CF08", VA = "0x155CF08")]
	public Vector3 GetVelocityLastFrame()
	{
		return default;
	}

	[Token(Token = "0x6002428")]
	[Address(RVA = "0x155CF18", Offset = "0x155CF18", VA = "0x155CF18")]
	public void ForceGroundedForSeconds(float secs)
	{
	}

	[Token(Token = "0x6002429")]
	[Address(RVA = "0x155C9A0", Offset = "0x155C9A0", VA = "0x155C9A0")]
	private bool IsGrounded()
	{
		return default;
	}

	[Token(Token = "0x600242A")]
	[Address(RVA = "0x155CF20", Offset = "0x155CF20", VA = "0x155CF20")]
	private void OnCollisionEnter(Collision c)
	{
	}

	[Token(Token = "0x600242B")]
	[Address(RVA = "0x155D1E0", Offset = "0x155D1E0", VA = "0x155D1E0")]
	private void OnCollisionStay(Collision c)
	{
	}

	[Token(Token = "0x600242C")]
	[Address(RVA = "0x155D45C", Offset = "0x155D45C", VA = "0x155D45C")]
	private void OnCollisionExit(Collision c)
	{
	}

	[Token(Token = "0x600242D")]
	[Address(RVA = "0x155D588", Offset = "0x155D588", VA = "0x155D588")]
	public void ForceOutOfBounds()
	{
	}

	[Token(Token = "0x600242E")]
	[Address(RVA = "0x155D58C", Offset = "0x155D58C", VA = "0x155D58C")]
	public MarioLevelController()
	{
	}
}
