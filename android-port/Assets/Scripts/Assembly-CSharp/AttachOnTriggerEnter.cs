using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200006B")]
public class AttachOnTriggerEnter : MonoBehaviour
{
	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Collider triggerArea;

	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> acceptedObjects;

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x142BA18", Offset = "0x142BA18", VA = "0x142BA18")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x142BBD0", Offset = "0x142BBD0", VA = "0x142BBD0")]
	public AttachOnTriggerEnter()
	{
	}
}
