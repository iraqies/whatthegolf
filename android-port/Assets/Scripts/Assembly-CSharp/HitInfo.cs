using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003C7")]
public struct HitInfo
{
	[Token(Token = "0x40014C0")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 point;

	[Token(Token = "0x40014C1")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 incomingVelocity;

	[Token(Token = "0x40014C2")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 impactOnNormal;

	[Token(Token = "0x40014C3")]
	[FieldOffset(Offset = "0x28")]
	public GameObject childHit;

	[Token(Token = "0x40014C4")]
	[FieldOffset(Offset = "0x30")]
	public GameObject otherHit;

	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x14CD214", Offset = "0x14CD214", VA = "0x14CD214")]
	public HitInfo(Vector3 point, Vector3 impactOnNormal, GameObject childHit, GameObject otherHit)
	{
	}
}
