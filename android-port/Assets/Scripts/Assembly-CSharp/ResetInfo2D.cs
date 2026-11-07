using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C21")]
public class ResetInfo2D
{
	[Token(Token = "0x40042E6")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 Position;

	[Token(Token = "0x40042E7")]
	[FieldOffset(Offset = "0x1C")]
	public float Rotation;

	[Token(Token = "0x40042E8")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 Velocity;

	[Token(Token = "0x40042E9")]
	[FieldOffset(Offset = "0x2C")]
	public float AngularVelocity;

	[Token(Token = "0x6003A0A")]
	[Address(RVA = "0x164A5C8", Offset = "0x164A5C8", VA = "0x164A5C8")]
	public ResetInfo2D()
	{
	}
}
