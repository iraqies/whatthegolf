using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B24")]
public class RotateWithVelocity : MonoBehaviour
{
	[Token(Token = "0x4003E50")]
	[FieldOffset(Offset = "0x18")]
	public float RotationSpeed;

	[Token(Token = "0x4003E51")]
	[FieldOffset(Offset = "0x1C")]
	public bool Inverse;

	[Token(Token = "0x4003E52")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x4003E53")]
	[FieldOffset(Offset = "0x28")]
	public bool RotateRigidbody;

	[Token(Token = "0x4003E54")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody _rigid;

	[Token(Token = "0x6003521")]
	[Address(RVA = "0x16604E8", Offset = "0x16604E8", VA = "0x16604E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6003522")]
	[Address(RVA = "0x1660594", Offset = "0x1660594", VA = "0x1660594")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003523")]
	[Address(RVA = "0x1660904", Offset = "0x1660904", VA = "0x1660904")]
	public RotateWithVelocity()
	{
	}
}
