using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000787")]
public class Killable : MonoBehaviour
{
	[Token(Token = "0x40027C9")]
	[FieldOffset(Offset = "0x18")]
	public Action OnKilled;

	[Token(Token = "0x6002297")]
	[Address(RVA = "0x14FEA2C", Offset = "0x14FEA2C", VA = "0x14FEA2C")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002298")]
	[Address(RVA = "0x14FEC04", Offset = "0x14FEC04", VA = "0x14FEC04")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6002299")]
	[Address(RVA = "0x14FED7C", Offset = "0x14FED7C", VA = "0x14FED7C")]
	public Killable()
	{
	}
}
