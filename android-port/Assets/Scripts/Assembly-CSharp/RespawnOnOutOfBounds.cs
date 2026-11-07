using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000811")]
public class RespawnOnOutOfBounds : MonoBehaviour
{
	[Token(Token = "0x4002B6D")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 startPos;

	[Token(Token = "0x4002B6E")]
	[FieldOffset(Offset = "0x24")]
	private Quaternion startRot;

	[Token(Token = "0x6002514")]
	[Address(RVA = "0x164CFFC", Offset = "0x164CFFC", VA = "0x164CFFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002515")]
	[Address(RVA = "0x164D058", Offset = "0x164D058", VA = "0x164D058")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002516")]
	[Address(RVA = "0x164D0E0", Offset = "0x164D0E0", VA = "0x164D0E0")]
	public void OutOfBounds()
	{
	}

	[Token(Token = "0x6002517")]
	[Address(RVA = "0x164D1F8", Offset = "0x164D1F8", VA = "0x164D1F8")]
	public RespawnOnOutOfBounds()
	{
	}
}
