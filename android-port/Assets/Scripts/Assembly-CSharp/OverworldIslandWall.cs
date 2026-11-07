using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A0A")]
public class OverworldIslandWall : MonoBehaviour
{
	[Token(Token = "0x400376D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject closedBridgeWall;

	[Token(Token = "0x400376E")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> openBridgeWall;

	[Token(Token = "0x400376F")]
	[FieldOffset(Offset = "0x28")]
	public bool isBridgeWall;

	[Token(Token = "0x6002FA5")]
	[Address(RVA = "0x15BA350", Offset = "0x15BA350", VA = "0x15BA350")]
	public void SetBridgeCollider(bool isOpen)
	{
	}

	[Token(Token = "0x6002FA6")]
	[Address(RVA = "0x15BA528", Offset = "0x15BA528", VA = "0x15BA528")]
	public OverworldIslandWall()
	{
	}
}
