using System.Collections.Generic;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200081D")]
public class GunSpawner : MonoBehaviour
{
	[Token(Token = "0x4002BA3")]
	[FieldOffset(Offset = "0x18")]
	public Animator Animator;

	[Token(Token = "0x4002BA4")]
	[FieldOffset(Offset = "0x20")]
	public List<SuperGolfGun> AvailableGuns;

	[Token(Token = "0x4002BA5")]
	[FieldOffset(Offset = "0x28")]
	public Transform SpawnPosition;

	[Token(Token = "0x4002BA6")]
	[FieldOffset(Offset = "0x30")]
	public float ThrowForce;

	[Token(Token = "0x4002BA7")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 SpawnDirection;

	[Token(Token = "0x4002BA8")]
	[FieldOffset(Offset = "0x40")]
	public List<AudioClip> SpawnClips;

	[Token(Token = "0x4002BA9")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem SpawnParticles;

	[Token(Token = "0x4002BAA")]
	[FieldOffset(Offset = "0x50")]
	public float AutoUpTime;

	[Token(Token = "0x4002BAB")]
	[FieldOffset(Offset = "0x54")]
	private float cooldown;

	[Token(Token = "0x4002BAC")]
	[FieldOffset(Offset = "0x58")]
	private Timeline timeline;

	[Token(Token = "0x4002BAD")]
	[FieldOffset(Offset = "0x60")]
	private bool playerOnButton;

	[Token(Token = "0x6002540")]
	[Address(RVA = "0x14BF0C0", Offset = "0x14BF0C0", VA = "0x14BF0C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002541")]
	[Address(RVA = "0x14BF11C", Offset = "0x14BF11C", VA = "0x14BF11C")]
	private void Update()
	{
	}

	[Token(Token = "0x6002542")]
	[Address(RVA = "0x14BF224", Offset = "0x14BF224", VA = "0x14BF224")]
	private void Trigger()
	{
	}

	[Token(Token = "0x6002543")]
	[Address(RVA = "0x14BF290", Offset = "0x14BF290", VA = "0x14BF290")]
	public void SpawnNewGun()
	{
	}

	[Token(Token = "0x6002544")]
	[Address(RVA = "0x14BF438", Offset = "0x14BF438", VA = "0x14BF438")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002545")]
	[Address(RVA = "0x14BF514", Offset = "0x14BF514", VA = "0x14BF514")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6002546")]
	[Address(RVA = "0x14BF584", Offset = "0x14BF584", VA = "0x14BF584")]
	public GunSpawner()
	{
	}
}
