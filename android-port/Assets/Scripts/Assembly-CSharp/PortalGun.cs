using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using VFX;

[Token(Token = "0x2000801")]
public class PortalGun : GolfBallShooterBase
{
	[Token(Token = "0x4002AE9")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 Up;

	[Token(Token = "0x4002AEA")]
	[FieldOffset(Offset = "0x70")]
	public List<GameObject> portals;

	[Token(Token = "0x4002AEB")]
	[FieldOffset(Offset = "0x78")]
	public LayerMask HitLayers;

	[Token(Token = "0x4002AEC")]
	[FieldOffset(Offset = "0x7C")]
	public LayerMask BlockLayers;

	[Token(Token = "0x4002AED")]
	[FieldOffset(Offset = "0x80")]
	public float HitOffsetFromWall;

	[Token(Token = "0x4002AEE")]
	[FieldOffset(Offset = "0x88")]
	public AnimationCurve ShootCurve;

	[Token(Token = "0x4002AEF")]
	[FieldOffset(Offset = "0x90")]
	public float LineLife;

	[Token(Token = "0x4002AF0")]
	[FieldOffset(Offset = "0x94")]
	public bool Is2DLevel;

	[Token(Token = "0x4002AF1")]
	[FieldOffset(Offset = "0x98")]
	public ClipSettingsCollection placePortalSFX;

	[Token(Token = "0x4002AF2")]
	[FieldOffset(Offset = "0xA0")]
	public ClipSettingsCollection failPortalSFX;

	[Token(Token = "0x4002AF3")]
	[FieldOffset(Offset = "0xA8")]
	public bool lookWithPhysics;

	[Token(Token = "0x4002AF4")]
	[FieldOffset(Offset = "0xB0")]
	private LineRenderer shootLine;

	[Token(Token = "0x4002AF5")]
	[FieldOffset(Offset = "0xB8")]
	private float lineShootTimer;

	[Token(Token = "0x4002AF6")]
	[FieldOffset(Offset = "0xC0")]
	private TrajectoryProjector trajectoryProjector;

	[Token(Token = "0x4002AF7")]
	[FieldOffset(Offset = "0xC8")]
	public Transform BarrelTransform;

	[Token(Token = "0x4002AF8")]
	[FieldOffset(Offset = "0xD0")]
	public SpriteRenderer AimRenderer;

	[Token(Token = "0x4002AF9")]
	[FieldOffset(Offset = "0xD8")]
	public bool flipPortal;

	[Token(Token = "0x4002AFA")]
	[FieldOffset(Offset = "0xD9")]
	private bool validShot;

	[Token(Token = "0x4002AFB")]
	[FieldOffset(Offset = "0xDC")]
	private Quaternion targetRotation;

	[Token(Token = "0x60024BD")]
	[Address(RVA = "0x161B6E8", Offset = "0x161B6E8", VA = "0x161B6E8", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60024BE")]
	[Address(RVA = "0x161B774", Offset = "0x161B774", VA = "0x161B774")]
	private void Update()
	{
	}

	[Token(Token = "0x60024BF")]
	[Address(RVA = "0x161B870", Offset = "0x161B870", VA = "0x161B870", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60024C0")]
	[Address(RVA = "0x161BC7C", Offset = "0x161BC7C", VA = "0x161BC7C")]
	private void HasShot(bool hasHit, Vector3 point, Vector3 normal)
	{
	}

	[Token(Token = "0x60024C1")]
	[Address(RVA = "0x161C298", Offset = "0x161C298", VA = "0x161C298")]
	private bool IsValidShot(Vector3 dir)
	{
		return default;
	}

	[Token(Token = "0x60024C2")]
	[Address(RVA = "0x161C474", Offset = "0x161C474", VA = "0x161C474", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60024C3")]
	[Address(RVA = "0x161C590", Offset = "0x161C590", VA = "0x161C590", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60024C4")]
	[Address(RVA = "0x161C6E8", Offset = "0x161C6E8", VA = "0x161C6E8")]
	public PortalGun()
	{
	}
}
