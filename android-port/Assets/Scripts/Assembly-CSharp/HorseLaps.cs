using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000793")]
public class HorseLaps : MonoBehaviour
{
	[Token(Token = "0x40027FB")]
	[FieldOffset(Offset = "0x18")]
	public int NumberOfLaps;

	[Token(Token = "0x40027FC")]
	[FieldOffset(Offset = "0x20")]
	public List<BoxCollider> Waypoints;

	[Token(Token = "0x40027FD")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<GameObject, int> lapsLeft;

	[Token(Token = "0x40027FE")]
	[FieldOffset(Offset = "0x30")]
	private bool horseCompletedTrack;

	[Token(Token = "0x60022BC")]
	[Address(RVA = "0x14D542C", Offset = "0x14D542C", VA = "0x14D542C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60022BD")]
	[Address(RVA = "0x14D54A4", Offset = "0x14D54A4", VA = "0x14D54A4")]
	public bool HorseLap(GameObject horse, bool isPlayer)
	{
		return default;
	}

	[Token(Token = "0x60022BE")]
	[Address(RVA = "0x14D56C0", Offset = "0x14D56C0", VA = "0x14D56C0")]
	public HorseLaps()
	{
	}
}
