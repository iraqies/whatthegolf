using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200086B")]
public class StickyStretch : MonoBehaviour
{
	[Token(Token = "0x4002E01")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int SquashID;

	[Token(Token = "0x4002E02")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int RadiusID;

	[Token(Token = "0x4002E03")]
	[FieldOffset(Offset = "0x8")]
	private static MaterialPropertyBlock _mpb;

	[Token(Token = "0x4002E04")]
	[FieldOffset(Offset = "0x18")]
	public MeshRenderer MeshRenderer;

	[Token(Token = "0x4002E05")]
	[FieldOffset(Offset = "0x20")]
	public float CollisionRadius;

	[Token(Token = "0x4002E06")]
	[FieldOffset(Offset = "0x24")]
	public bool Use2DPhysics;

	[Token(Token = "0x4002E07")]
	[FieldOffset(Offset = "0x28")]
	public StickyBall Sticky;

	[Token(Token = "0x4002E08")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 ExtraRotationOffset;

	[Token(Token = "0x4002E09")]
	[FieldOffset(Offset = "0x3C")]
	public float StuckSquash;

	[Token(Token = "0x4002E0A")]
	[FieldOffset(Offset = "0x40")]
	public float UnstuckSquash;

	[Token(Token = "0x4002E0B")]
	[FieldOffset(Offset = "0x44")]
	public float Dampening;

	[Token(Token = "0x4002E0C")]
	[FieldOffset(Offset = "0x48")]
	public float Stiffness;

	[Token(Token = "0x4002E0D")]
	[FieldOffset(Offset = "0x4C")]
	public float ValueThreshold;

	[Token(Token = "0x4002E0E")]
	[FieldOffset(Offset = "0x50")]
	private float currentVelocity;

	[Token(Token = "0x4002E0F")]
	[FieldOffset(Offset = "0x54")]
	private bool stuck;

	[Token(Token = "0x4002E10")]
	[FieldOffset(Offset = "0x58")]
	private float targetSquash;

	[Token(Token = "0x4002E11")]
	[FieldOffset(Offset = "0x5C")]
	private float currentSquash;

	[Token(Token = "0x4002E12")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 stuckLocalScale;

	[Token(Token = "0x60026D8")]
	[Address(RVA = "0x16E087C", Offset = "0x16E087C", VA = "0x16E087C")]
	private void Start()
	{
	}

	[Token(Token = "0x60026D9")]
	[Address(RVA = "0x16E0A08", Offset = "0x16E0A08", VA = "0x16E0A08")]
	private void OnUnStuck()
	{
	}

	[Token(Token = "0x60026DA")]
	[Address(RVA = "0x16E0A5C", Offset = "0x16E0A5C", VA = "0x16E0A5C")]
	private void OnStuck(Vector3 normal)
	{
	}

	[Token(Token = "0x60026DB")]
	[Address(RVA = "0x16E0AF8", Offset = "0x16E0AF8", VA = "0x16E0AF8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60026DC")]
	[Address(RVA = "0x16E0D58", Offset = "0x16E0D58", VA = "0x16E0D58")]
	public StickyStretch()
	{
	}
}
