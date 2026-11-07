using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BE9")]
public class FireExtinguisherTrigger : MonoBehaviour
{
	[Token(Token = "0x40041FB")]
	[FieldOffset(Offset = "0x18")]
	public int flameDamage;

	[Token(Token = "0x40041FC")]
	[FieldOffset(Offset = "0x20")]
	private List<ExtinguishableFlame> flamesInside;

	[Token(Token = "0x6003918")]
	[Address(RVA = "0x1465DF0", Offset = "0x1465DF0", VA = "0x1465DF0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6003919")]
	[Address(RVA = "0x1465F14", Offset = "0x1465F14", VA = "0x1465F14")]
	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	[Token(Token = "0x600391A")]
	[Address(RVA = "0x1465FF0", Offset = "0x1465FF0", VA = "0x1465FF0")]
	private void Update()
	{
	}

	[Token(Token = "0x600391B")]
	[Address(RVA = "0x14660A0", Offset = "0x14660A0", VA = "0x14660A0")]
	public FireExtinguisherTrigger()
	{
	}
}
