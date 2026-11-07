using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003C3")]
public class SetRTPCOnTrigger : BaseRTPCSetter
{
	[Token(Token = "0x40014AF")]
	[FieldOffset(Offset = "0x22")]
	public bool onExit;

	[Token(Token = "0x40014B0")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask layerMask;

	[Token(Token = "0x40014B1")]
	[FieldOffset(Offset = "0x28")]
	public bool canOnlyTriggerOnce;

	[Token(Token = "0x40014B2")]
	[FieldOffset(Offset = "0x29")]
	public bool useSpecificObjects;

	[Token(Token = "0x40014B3")]
	[FieldOffset(Offset = "0x30")]
	public List<GameObject> objects;

	[Token(Token = "0x40014B4")]
	[FieldOffset(Offset = "0x38")]
	private bool isTriggered;

	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x168F044", Offset = "0x168F044", VA = "0x168F044")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60011CD")]
	[Address(RVA = "0x168F140", Offset = "0x168F140", VA = "0x168F140")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x168F248", Offset = "0x168F248", VA = "0x168F248")]
	public SetRTPCOnTrigger()
	{
	}
}
