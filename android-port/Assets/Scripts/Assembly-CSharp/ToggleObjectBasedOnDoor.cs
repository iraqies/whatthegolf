using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A6D")]
public class ToggleObjectBasedOnDoor : MonoBehaviour
{
	[Token(Token = "0x40039BC")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> ObjectsToToggle;

	[Token(Token = "0x40039BD")]
	[FieldOffset(Offset = "0x20")]
	public bool OnIfDisabled;

	[Token(Token = "0x60031B5")]
	[Address(RVA = "0x171B920", Offset = "0x171B920", VA = "0x171B920")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60031B6")]
	[Address(RVA = "0x171BAD0", Offset = "0x171BAD0", VA = "0x171BAD0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60031B7")]
	[Address(RVA = "0x171BC78", Offset = "0x171BC78", VA = "0x171BC78")]
	public ToggleObjectBasedOnDoor()
	{
	}
}
