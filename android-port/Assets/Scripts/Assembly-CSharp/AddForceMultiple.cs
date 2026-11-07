using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E68")]
public class AddForceMultiple : MonoBehaviour
{
	[Token(Token = "0x4004DFE")]
	[FieldOffset(Offset = "0x18")]
	public bool onAwake;

	[Token(Token = "0x4004DFF")]
	[FieldOffset(Offset = "0x20")]
	public AddForce[] objectsWithAddForce;

	[Token(Token = "0x600435E")]
	[Address(RVA = "0x1406F60", Offset = "0x1406F60", VA = "0x1406F60")]
	private void Start()
	{
	}

	[Token(Token = "0x600435F")]
	[Address(RVA = "0x1406FD4", Offset = "0x1406FD4", VA = "0x1406FD4")]
	public void AddForce()
	{
	}

	[Token(Token = "0x6004360")]
	[Address(RVA = "0x140703C", Offset = "0x140703C", VA = "0x140703C")]
	public AddForceMultiple()
	{
	}
}
