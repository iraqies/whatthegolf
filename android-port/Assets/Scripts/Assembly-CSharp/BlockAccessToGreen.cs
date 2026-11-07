using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000709")]
public class BlockAccessToGreen : MonoBehaviour
{
	[Token(Token = "0x40024FF")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> BlockingPeople;

	[Token(Token = "0x4002500")]
	[FieldOffset(Offset = "0x20")]
	public float RotateSpeed;

	[Token(Token = "0x4002501")]
	[FieldOffset(Offset = "0x24")]
	public float Distance;

	[Token(Token = "0x6002078")]
	[Address(RVA = "0x1612B40", Offset = "0x1612B40", VA = "0x1612B40")]
	private void Start()
	{
	}

	[Token(Token = "0x6002079")]
	[Address(RVA = "0x1612D44", Offset = "0x1612D44", VA = "0x1612D44")]
	private void Update()
	{
	}

	[Token(Token = "0x600207A")]
	[Address(RVA = "0x1612DBC", Offset = "0x1612DBC", VA = "0x1612DBC")]
	public BlockAccessToGreen()
	{
	}
}
