using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C22")]
public class ResetInfo
{
	[Token(Token = "0x40042EA")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 Position;

	[Token(Token = "0x40042EB")]
	[FieldOffset(Offset = "0x1C")]
	public Quaternion Rotation;

	[Token(Token = "0x40042EC")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 Velocity;

	[Token(Token = "0x40042ED")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 AngularVelocity;

	[Token(Token = "0x6003A0B")]
	[Address(RVA = "0x164A5C0", Offset = "0x164A5C0", VA = "0x164A5C0")]
	public ResetInfo()
	{
	}
}
