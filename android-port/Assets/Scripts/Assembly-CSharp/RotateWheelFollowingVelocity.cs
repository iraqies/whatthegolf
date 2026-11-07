using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DD1")]
public class RotateWheelFollowingVelocity : MonoBehaviour
{
	[Token(Token = "0x4004B4F")]
	[FieldOffset(Offset = "0x18")]
	public float rotationSpeed;

	[Token(Token = "0x4004B50")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 rotationVector;

	[Token(Token = "0x4004B51")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 velocity;

	[Token(Token = "0x4004B52")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 lastPos;

	[Token(Token = "0x600411D")]
	[Address(RVA = "0x165FEA0", Offset = "0x165FEA0", VA = "0x165FEA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600411E")]
	[Address(RVA = "0x1660000", Offset = "0x1660000", VA = "0x1660000")]
	public RotateWheelFollowingVelocity()
	{
	}
}
