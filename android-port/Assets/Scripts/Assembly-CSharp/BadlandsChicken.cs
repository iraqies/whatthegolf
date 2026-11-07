using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006DA")]
public class BadlandsChicken : MonoBehaviour
{
	[Token(Token = "0x40023E0")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem DeathParticles;

	[Token(Token = "0x40023E1")]
	[FieldOffset(Offset = "0x20")]
	public float OutOfScreenDeathThreshold;

	[Token(Token = "0x40023E2")]
	[FieldOffset(Offset = "0x28")]
	public Action<BadlandsChicken> OnDeath;

	[Token(Token = "0x40023E3")]
	[FieldOffset(Offset = "0x30")]
	public RandomAudioClips deathClips;

	[Token(Token = "0x40023E4")]
	[FieldOffset(Offset = "0x38")]
	private Camera mainCam;

	[Token(Token = "0x40023E5")]
	[FieldOffset(Offset = "0x40")]
	private bool dead;

	[Token(Token = "0x40023E6")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody rigid;

	[Token(Token = "0x6001FA1")]
	[Address(RVA = "0x1516C78", Offset = "0x1516C78", VA = "0x1516C78")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001FA2")]
	[Address(RVA = "0x1516CE0", Offset = "0x1516CE0", VA = "0x1516CE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001FA3")]
	[Address(RVA = "0x1516DFC", Offset = "0x1516DFC", VA = "0x1516DFC")]
	public void Die()
	{
	}

	[Token(Token = "0x6001FA4")]
	[Address(RVA = "0x1516D20", Offset = "0x1516D20", VA = "0x1516D20")]
	public float GetScreenPosX()
	{
		return default;
	}

	[Token(Token = "0x6001FA5")]
	[Address(RVA = "0x1516EE0", Offset = "0x1516EE0", VA = "0x1516EE0")]
	public Vector3 GetCurrentSpeed()
	{
		return default;
	}

	[Token(Token = "0x6001FA6")]
	[Address(RVA = "0x1516EFC", Offset = "0x1516EFC", VA = "0x1516EFC")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6001FA7")]
	[Address(RVA = "0x1516FE4", Offset = "0x1516FE4", VA = "0x1516FE4")]
	public BadlandsChicken()
	{
	}
}
