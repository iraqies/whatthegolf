using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002FF")]
public class HotdogSpawner : MonoBehaviour
{
	[Token(Token = "0x4001099")]
	[FieldOffset(Offset = "0x18")]
	public CollisionEvents hotdogStand;

	[Token(Token = "0x400109A")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody hotdogPrefab;

	[Token(Token = "0x400109B")]
	[FieldOffset(Offset = "0x28")]
	public Transform spawnPositions;

	[Token(Token = "0x400109C")]
	[FieldOffset(Offset = "0x30")]
	public float spawnForce;

	[Token(Token = "0x400109D")]
	[FieldOffset(Offset = "0x34")]
	public int spawnCountPerCollision;

	[Token(Token = "0x400109E")]
	[FieldOffset(Offset = "0x38")]
	public float spawnInterval;

	[Token(Token = "0x400109F")]
	[FieldOffset(Offset = "0x3C")]
	public float impactThreshold;

	[Token(Token = "0x40010A0")]
	[FieldOffset(Offset = "0x40")]
	public RandomAudioClips spawnClips;

	[Token(Token = "0x40010A1")]
	[FieldOffset(Offset = "0x48")]
	public int maxAmount;

	[Token(Token = "0x40010A2")]
	[FieldOffset(Offset = "0x4C")]
	private float nextSpawn;

	[Token(Token = "0x40010A3")]
	[FieldOffset(Offset = "0x50")]
	private float time;

	[Token(Token = "0x40010A4")]
	[FieldOffset(Offset = "0x58")]
	private List<GameObject> hotdogs;

	[Token(Token = "0x6000DDA")]
	[Address(RVA = "0x14DC9D0", Offset = "0x14DC9D0", VA = "0x14DC9D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000DDB")]
	[Address(RVA = "0x14DC9D4", Offset = "0x14DC9D4", VA = "0x14DC9D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0x14DCCDC", Offset = "0x14DCCDC", VA = "0x14DCCDC")]
	public HotdogSpawner()
	{
	}
}
