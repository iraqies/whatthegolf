using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B2F")]
public class SpeedBoostPad : MonoBehaviour
{
	[Token(Token = "0x4003E6C")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 ForceDirection;

	[Token(Token = "0x4003E6D")]
	[FieldOffset(Offset = "0x24")]
	public float SpeedBoost;

	[Token(Token = "0x4003E6E")]
	[FieldOffset(Offset = "0x28")]
	public ForceMode Mode;

	[Token(Token = "0x4003E6F")]
	[FieldOffset(Offset = "0x30")]
	private List<Rigidbody> affectedRigidbodies;

	[Token(Token = "0x600353E")]
	[Address(RVA = "0x16D073C", Offset = "0x16D073C", VA = "0x16D073C")]
	private void Start()
	{
	}

	[Token(Token = "0x600353F")]
	[Address(RVA = "0x16D07B4", Offset = "0x16D07B4", VA = "0x16D07B4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003540")]
	[Address(RVA = "0x16D0948", Offset = "0x16D0948", VA = "0x16D0948")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003541")]
	[Address(RVA = "0x16D0A94", Offset = "0x16D0A94", VA = "0x16D0A94")]
	private void OnCollisionExit(Collision other)
	{
	}

	[Token(Token = "0x6003542")]
	[Address(RVA = "0x16D0B2C", Offset = "0x16D0B2C", VA = "0x16D0B2C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6003543")]
	[Address(RVA = "0x16D0C00", Offset = "0x16D0C00", VA = "0x16D0C00")]
	public SpeedBoostPad()
	{
	}
}
