using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003C4")]
public class SetStateOnTrigger : BaseStateSetter
{
	[Token(Token = "0x40014B5")]
	[FieldOffset(Offset = "0x1D")]
	public bool onExit;

	[Token(Token = "0x40014B6")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask layerMask;

	[Token(Token = "0x40014B7")]
	[FieldOffset(Offset = "0x24")]
	public bool canOnlyTriggerOnce;

	[Token(Token = "0x40014B8")]
	[FieldOffset(Offset = "0x25")]
	public bool useSpecificObjects;

	[Token(Token = "0x40014B9")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> objects;

	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x168FE24", Offset = "0x168FE24", VA = "0x168FE24")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x168FF24", Offset = "0x168FF24", VA = "0x168FF24")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x1690024", Offset = "0x1690024", VA = "0x1690024")]
	public SetStateOnTrigger()
	{
	}
}
