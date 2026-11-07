using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A0")]
public class JetpackJoyride : GolfBall2DShooterBase
{
	[Token(Token = "0x400284A")]
	[FieldOffset(Offset = "0x48")]
	public float UpForce;

	[Token(Token = "0x400284B")]
	[FieldOffset(Offset = "0x4C")]
	public float MoveSpeed;

	[Token(Token = "0x400284C")]
	[FieldOffset(Offset = "0x50")]
	public Animator Animator;

	[Token(Token = "0x400284D")]
	[FieldOffset(Offset = "0x58")]
	public float GroundedCheckDistance;

	[Token(Token = "0x400284E")]
	[FieldOffset(Offset = "0x5C")]
	public LayerMask GroundedLayers;

	[Token(Token = "0x400284F")]
	[FieldOffset(Offset = "0x60")]
	public List<ParticleSystem> ShootParticles;

	[Token(Token = "0x4002850")]
	[FieldOffset(Offset = "0x68")]
	public AudioSource RunSource;

	[Token(Token = "0x4002851")]
	[FieldOffset(Offset = "0x70")]
	private bool boosting;

	[Token(Token = "0x60022F5")]
	[Address(RVA = "0x14F62C8", Offset = "0x14F62C8", VA = "0x14F62C8", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x60022F6")]
	[Address(RVA = "0x14F6418", Offset = "0x14F6418", VA = "0x14F6418", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60022F7")]
	[Address(RVA = "0x14F6428", Offset = "0x14F6428", VA = "0x14F6428", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x60022F8")]
	[Address(RVA = "0x14F6584", Offset = "0x14F6584", VA = "0x14F6584", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60022F9")]
	[Address(RVA = "0x14F66E0", Offset = "0x14F66E0", VA = "0x14F66E0", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60022FA")]
	[Address(RVA = "0x14F6738", Offset = "0x14F6738", VA = "0x14F6738")]
	private void Update()
	{
	}

	[Token(Token = "0x60022FB")]
	[Address(RVA = "0x14F68D8", Offset = "0x14F68D8", VA = "0x14F68D8")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x60022FC")]
	[Address(RVA = "0x14F698C", Offset = "0x14F698C", VA = "0x14F698C")]
	public JetpackJoyride()
	{
	}
}
