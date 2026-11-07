using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003C8")]
public struct TriggerInfo
{
	[Token(Token = "0x40014C5")]
	[FieldOffset(Offset = "0x0")]
	public GameObject thisHit;

	[Token(Token = "0x40014C6")]
	[FieldOffset(Offset = "0x8")]
	public GameObject otherHit;

	[Token(Token = "0x40014C7")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 point;
}
