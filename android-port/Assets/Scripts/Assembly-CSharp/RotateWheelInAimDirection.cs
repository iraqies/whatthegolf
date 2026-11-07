using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C2B")]
public class RotateWheelInAimDirection : MonoBehaviour
{
	[Token(Token = "0x4004314")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 Up;

	[Token(Token = "0x4004315")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody2D rigid2D;

	[Token(Token = "0x4004316")]
	[FieldOffset(Offset = "0x30")]
	private float angleDrag;

	[Token(Token = "0x4004317")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 lastBoostDirection;

	[Token(Token = "0x4004318")]
	[FieldOffset(Offset = "0x40")]
	private float currentDragVel;

	[Token(Token = "0x6003A2A")]
	[Address(RVA = "0x16600BC", Offset = "0x16600BC", VA = "0x16600BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A2B")]
	[Address(RVA = "0x166018C", Offset = "0x166018C", VA = "0x166018C")]
	private void OnOnAimUpdate(Vector3 boost, bool b)
	{
	}

	[Token(Token = "0x6003A2C")]
	[Address(RVA = "0x16601FC", Offset = "0x16601FC", VA = "0x16601FC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003A2D")]
	[Address(RVA = "0x1660248", Offset = "0x1660248", VA = "0x1660248")]
	public RotateWheelInAimDirection()
	{
	}
}
