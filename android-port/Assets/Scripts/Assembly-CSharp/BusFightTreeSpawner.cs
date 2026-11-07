using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000671")]
public class BusFightTreeSpawner : MonoBehaviour
{
	[Token(Token = "0x400216B")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> edgeTrees;

	[Token(Token = "0x400216C")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> trees;

	[Token(Token = "0x400216D")]
	[FieldOffset(Offset = "0x28")]
	public float distanceInterval;

	[Token(Token = "0x400216E")]
	[FieldOffset(Offset = "0x2C")]
	public float spawnDistanceFromBus;

	[Token(Token = "0x400216F")]
	[FieldOffset(Offset = "0x30")]
	public float centerAvoidRadius;

	[Token(Token = "0x4002170")]
	[FieldOffset(Offset = "0x38")]
	private BusFight bus;

	[Token(Token = "0x4002171")]
	[FieldOffset(Offset = "0x40")]
	private float nextSpawnZ;

	[Token(Token = "0x4002172")]
	[FieldOffset(Offset = "0x44")]
	private float nextEdgeSpawnZ;

	[Token(Token = "0x6001D7E")]
	[Address(RVA = "0x17D853C", Offset = "0x17D853C", VA = "0x17D853C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D7F")]
	[Address(RVA = "0x17D85C0", Offset = "0x17D85C0", VA = "0x17D85C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D80")]
	[Address(RVA = "0x17D88F0", Offset = "0x17D88F0", VA = "0x17D88F0")]
	private bool MakeEdgeTree()
	{
		return default;
	}

	[Token(Token = "0x6001D81")]
	[Address(RVA = "0x17D86E4", Offset = "0x17D86E4", VA = "0x17D86E4")]
	private bool MakeTree()
	{
		return default;
	}

	[Token(Token = "0x6001D82")]
	[Address(RVA = "0x17D8AFC", Offset = "0x17D8AFC", VA = "0x17D8AFC")]
	public BusFightTreeSpawner()
	{
	}
}
