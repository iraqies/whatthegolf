using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x2000726")]
public class SpitShooter2D : GolfBall2DShooterBase
{
	[Token(Token = "0x40025B0")]
	[FieldOffset(Offset = "0x48")]
	public Transform HeadTransform;

	[Token(Token = "0x40025B1")]
	[FieldOffset(Offset = "0x50")]
	public float ShootForce;

	[Token(Token = "0x40025B2")]
	[FieldOffset(Offset = "0x58")]
	public Transform ShootOriginTransform;

	[Token(Token = "0x40025B3")]
	[FieldOffset(Offset = "0x60")]
	public Spit2D SpitTemplate;

	[Token(Token = "0x40025B4")]
	[FieldOffset(Offset = "0x68")]
	private ObjectPool<Spit2D> spitPool;

	[Token(Token = "0x60020FD")]
	[Address(RVA = "0x16D7014", Offset = "0x16D7014", VA = "0x16D7014")]
	private void Start()
	{
	}

	[Token(Token = "0x60020FE")]
	[Address(RVA = "0x16D74A0", Offset = "0x16D74A0", VA = "0x16D74A0")]
	private void BallOnOnAimUpdate(Vector3 vector3, bool b)
	{
	}

	[Token(Token = "0x60020FF")]
	[Address(RVA = "0x16D7560", Offset = "0x16D7560", VA = "0x16D7560")]
	private void OnHitGoal()
	{
	}

	[Token(Token = "0x6002100")]
	[Address(RVA = "0x16D7594", Offset = "0x16D7594", VA = "0x16D7594", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002101")]
	[Address(RVA = "0x16D76D4", Offset = "0x16D76D4", VA = "0x16D76D4")]
	private Spit2D SpawnNewArrow()
	{
		return null;
	}

	[Token(Token = "0x6002102")]
	[Address(RVA = "0x16D7814", Offset = "0x16D7814", VA = "0x16D7814")]
	public SpitShooter2D()
	{
	}

	[Token(Token = "0x6002103")]
	[Address(RVA = "0x16D7824", Offset = "0x16D7824", VA = "0x16D7824")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65AE0", Offset = "0x65AE0")]
	private void _003CStart_003Eb__5_0(GameObject s)
	{
	}
}
