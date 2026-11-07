using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007F7")]
public class PeggleShooter : GolfBall2DShooterBase
{
	[Token(Token = "0x4002AAB")]
	[FieldOffset(Offset = "0x48")]
	public Rigidbody2D Ball;

	[Token(Token = "0x4002AAC")]
	[FieldOffset(Offset = "0x50")]
	public Transform BallSpawnPoint;

	[Token(Token = "0x4002AAD")]
	[FieldOffset(Offset = "0x58")]
	public float ShootForce;

	[Token(Token = "0x4002AAE")]
	[FieldOffset(Offset = "0x60")]
	public Transform BobContainer;

	[Token(Token = "0x4002AAF")]
	[FieldOffset(Offset = "0x68")]
	public AudioSource HitSource;

	[Token(Token = "0x4002AB0")]
	[FieldOffset(Offset = "0x70")]
	public List<AudioClip> ShootClips;

	[Token(Token = "0x4002AB1")]
	[FieldOffset(Offset = "0x78")]
	private List<PeggleBob> bobs;

	[Token(Token = "0x4002AB2")]
	[FieldOffset(Offset = "0x80")]
	private float startPitch;

	[Token(Token = "0x6002492")]
	[Address(RVA = "0x15DDC7C", Offset = "0x15DDC7C", VA = "0x15DDC7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002493")]
	[Address(RVA = "0x15DDD08", Offset = "0x15DDD08", VA = "0x15DDD08")]
	private void Update()
	{
	}

	[Token(Token = "0x6002494")]
	[Address(RVA = "0x15DDEC0", Offset = "0x15DDEC0", VA = "0x15DDEC0", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6002495")]
	[Address(RVA = "0x15DDFE0", Offset = "0x15DDFE0", VA = "0x15DDFE0", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002496")]
	[Address(RVA = "0x15DE11C", Offset = "0x15DE11C", VA = "0x15DE11C")]
	public PeggleShooter()
	{
	}
}
