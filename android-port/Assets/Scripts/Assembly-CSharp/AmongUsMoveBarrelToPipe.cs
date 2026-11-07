using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E07")]
public class AmongUsMoveBarrelToPipe : MonoBehaviour
{
	[Token(Token = "0x4004C52")]
	[FieldOffset(Offset = "0x18")]
	private GameObject barrel;

	[Token(Token = "0x4004C53")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody barrelRigidbody;

	[Token(Token = "0x4004C54")]
	[FieldOffset(Offset = "0x28")]
	public Transform positionToMoveTo;

	[Token(Token = "0x4004C55")]
	[FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x60041FA")]
	[Address(RVA = "0x140FBC4", Offset = "0x140FBC4", VA = "0x140FBC4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60041FB")]
	[Address(RVA = "0x140FC94", Offset = "0x140FC94", VA = "0x140FC94")]
	private void Update()
	{
	}

	[Token(Token = "0x60041FC")]
	[Address(RVA = "0x140FE98", Offset = "0x140FE98", VA = "0x140FE98")]
	public AmongUsMoveBarrelToPipe()
	{
	}
}
