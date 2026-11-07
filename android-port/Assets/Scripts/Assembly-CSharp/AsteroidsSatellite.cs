using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000B3")]
public class AsteroidsSatellite : GolfBallShooterBase
{
	[Token(Token = "0x40002C8")]
	[FieldOffset(Offset = "0x60")]
	public float ShootInterval;

	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0x64")]
	public float Speed;

	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 savedBoost;

	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x78")]
	private Rigidbody2D rigid;

	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0x80")]
	public GameObject LaserObject;

	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x88")]
	public Transform BarrelTransform;

	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x90")]
	public Animator WeaponAnim;

	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0x98")]
	public Animator SatelliteAnim;

	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject FireObject;

	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0xA8")]
	private bool invulnurable;

	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0xAC")]
	private float shootTimer;

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x142B3D0", Offset = "0x142B3D0", VA = "0x142B3D0", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x142B4A8", Offset = "0x142B4A8", VA = "0x142B4A8", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x142B620", Offset = "0x142B620", VA = "0x142B620")]
	private void Update()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x142B6F4", Offset = "0x142B6F4", VA = "0x142B6F4")]
	private void FireLaser()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x142B864", Offset = "0x142B864", VA = "0x142B864", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x142B86C", Offset = "0x142B86C", VA = "0x142B86C", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x142B900", Offset = "0x142B900", VA = "0x142B900")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x142BA08", Offset = "0x142BA08", VA = "0x142BA08")]
	public AsteroidsSatellite()
	{
	}
}
