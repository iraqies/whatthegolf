using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BAC")]
public class AddForceOnCollision : MonoBehaviour
{
	[Token(Token = "0x400411E")]
	[FieldOffset(Offset = "0x18")]
	public float Force;

	[Token(Token = "0x400411F")]
	[FieldOffset(Offset = "0x1C")]
	public float UpwardsForce;

	[Token(Token = "0x4004120")]
	[FieldOffset(Offset = "0x20")]
	public ForceMode ForceMode;

	[Token(Token = "0x4004121")]
	[FieldOffset(Offset = "0x24")]
	public bool AddToIncomingRigidbody;

	[Token(Token = "0x4004122")]
	[FieldOffset(Offset = "0x25")]
	public bool CheckLayer;

	[Token(Token = "0x4004123")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask LayerMask;

	[Token(Token = "0x4004124")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody m_ThisRigidbody;

	[Token(Token = "0x600385B")]
	[Address(RVA = "0x1407044", Offset = "0x1407044", VA = "0x1407044")]
	private void Awake()
	{
	}

	[Token(Token = "0x600385C")]
	[Address(RVA = "0x14070A0", Offset = "0x14070A0", VA = "0x14070A0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600385D")]
	[Address(RVA = "0x1407408", Offset = "0x1407408", VA = "0x1407408")]
	public AddForceOnCollision()
	{
	}
}
