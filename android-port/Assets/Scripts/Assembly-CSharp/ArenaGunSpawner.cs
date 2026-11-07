using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000116")]
public class ArenaGunSpawner : MonoBehaviour
{
	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0x18")]
	public List<SuperGolfGun> Guns;

	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 SpawnOffset;

	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x30")]
	private List<SuperGolfGun> currentGuns;

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x14230B4", Offset = "0x14230B4", VA = "0x14230B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x1423220", Offset = "0x1423220", VA = "0x1423220")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x14236F4", Offset = "0x14236F4", VA = "0x14236F4")]
	private void Update()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x14232BC", Offset = "0x14232BC", VA = "0x14232BC")]
	private void SpawnNewGuns()
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x142387C", Offset = "0x142387C", VA = "0x142387C")]
	public ArenaGunSpawner()
	{
	}
}
