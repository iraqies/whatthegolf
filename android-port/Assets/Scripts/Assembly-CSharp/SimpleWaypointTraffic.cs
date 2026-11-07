using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B8D")]
public class SimpleWaypointTraffic : MonoBehaviour
{
	[Token(Token = "0x4004057")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> Waypoints;

	[Token(Token = "0x4004058")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> CarPrefab;

	[Token(Token = "0x4004059")]
	[FieldOffset(Offset = "0x28")]
	public int NumberOfCars;

	[Token(Token = "0x400405A")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> _spawnedCars;

	[Token(Token = "0x60037BE")]
	[Address(RVA = "0x16B0400", Offset = "0x16B0400", VA = "0x16B0400")]
	private void Start()
	{
	}

	[Token(Token = "0x60037BF")]
	[Address(RVA = "0x16B0748", Offset = "0x16B0748", VA = "0x16B0748")]
	public SimpleWaypointTraffic()
	{
	}
}
