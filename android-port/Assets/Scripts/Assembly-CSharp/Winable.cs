using System;
using Audio.Rumble;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000790")]
public class Winable : MonoBehaviour
{
	[Token(Token = "0x40027F3")]
	[FieldOffset(Offset = "0x18")]
	public Action<Vector3> OnWon;

	[Token(Token = "0x40027F4")]
	[FieldOffset(Offset = "0x20")]
	public RumbleEventAsset rumbleOnWin;

	[Token(Token = "0x60022B1")]
	[Address(RVA = "0x1756E8C", Offset = "0x1756E8C", VA = "0x1756E8C")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60022B2")]
	[Address(RVA = "0x1756FB0", Offset = "0x1756FB0", VA = "0x1756FB0")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60022B3")]
	[Address(RVA = "0x17570D4", Offset = "0x17570D4", VA = "0x17570D4")]
	public Winable()
	{
	}
}
