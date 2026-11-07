using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000780")]
public class HoleInOneRoadSpawner : MonoBehaviour
{
	[Token(Token = "0x40027A6")]
	[FieldOffset(Offset = "0x18")]
	public Transform ball;

	[Token(Token = "0x40027A7")]
	[FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x40027A8")]
	[FieldOffset(Offset = "0x28")]
	public Transform tree;

	[Token(Token = "0x40027A9")]
	[FieldOffset(Offset = "0x30")]
	public List<Transform> treeSpawnPoints;

	[Token(Token = "0x40027AA")]
	[FieldOffset(Offset = "0x38")]
	public float treeSpawnInterval;

	[Token(Token = "0x40027AB")]
	[FieldOffset(Offset = "0x3C")]
	public bool isBad;

	[Token(Token = "0x40027AC")]
	[FieldOffset(Offset = "0x3D")]
	public bool isWin;

	[Token(Token = "0x40027AD")]
	[FieldOffset(Offset = "0x40")]
	public List<Transform> spawnedTrees;

	[Token(Token = "0x40027AE")]
	[FieldOffset(Offset = "0x48")]
	public List<Rigidbody2D> spawnedRigids;

	[Token(Token = "0x40027AF")]
	[FieldOffset(Offset = "0x50")]
	private float nextTree;

	[Token(Token = "0x600227C")]
	[Address(RVA = "0x14CF014", Offset = "0x14CF014", VA = "0x14CF014")]
	private void Awake()
	{
	}

	[Token(Token = "0x600227D")]
	[Address(RVA = "0x14CF018", Offset = "0x14CF018", VA = "0x14CF018")]
	private void Update()
	{
	}

	[Token(Token = "0x600227E")]
	[Address(RVA = "0x14CF45C", Offset = "0x14CF45C", VA = "0x14CF45C")]
	public HoleInOneRoadSpawner()
	{
	}
}
