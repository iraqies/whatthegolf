using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DFE")]
public class AmongUsBoulderChangeDirection : MonoBehaviour
{
	[Token(Token = "0x4004C28")]
	[FieldOffset(Offset = "0x18")]
	public float leftForce;

	[Token(Token = "0x4004C29")]
	[FieldOffset(Offset = "0x1C")]
	public float rightForce;

	[Token(Token = "0x4004C2A")]
	[FieldOffset(Offset = "0x20")]
	public float downForce;

	[Token(Token = "0x4004C2B")]
	[FieldOffset(Offset = "0x24")]
	public float leftTorque;

	[Token(Token = "0x4004C2C")]
	[FieldOffset(Offset = "0x28")]
	public float rightTorque;

	[Token(Token = "0x4004C2D")]
	[FieldOffset(Offset = "0x30")]
	private ConstantForce boulderConstantForce;

	[Token(Token = "0x4004C2E")]
	[FieldOffset(Offset = "0x38")]
	private AmongUsBoulderPlatformType platformType;

	[Token(Token = "0x60041DC")]
	[Address(RVA = "0x140EBBC", Offset = "0x140EBBC", VA = "0x140EBBC")]
	private void Start()
	{
	}

	[Token(Token = "0x60041DD")]
	[Address(RVA = "0x140EC18", Offset = "0x140EC18", VA = "0x140EC18")]
	public void GoLeft()
	{
	}

	[Token(Token = "0x60041DE")]
	[Address(RVA = "0x140EC6C", Offset = "0x140EC6C", VA = "0x140EC6C")]
	public void GoRight()
	{
	}

	[Token(Token = "0x60041DF")]
	[Address(RVA = "0x140ECC0", Offset = "0x140ECC0", VA = "0x140ECC0")]
	public void GoDown()
	{
	}

	[Token(Token = "0x60041E0")]
	[Address(RVA = "0x140ED14", Offset = "0x140ED14", VA = "0x140ED14")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60041E1")]
	[Address(RVA = "0x140EED0", Offset = "0x140EED0", VA = "0x140EED0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60041E2")]
	[Address(RVA = "0x140F040", Offset = "0x140F040", VA = "0x140F040")]
	public AmongUsBoulderChangeDirection()
	{
	}
}
