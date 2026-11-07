using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DD0")]
public class RotateToVelocity : MonoBehaviour
{
	[Token(Token = "0x4004B4C")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4004B4D")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 velocity;

	[Token(Token = "0x4004B4E")]
	[FieldOffset(Offset = "0x30")]
	public Transform transformTarget;

	[Token(Token = "0x600411A")]
	[Address(RVA = "0x165F8BC", Offset = "0x165F8BC", VA = "0x165F8BC")]
	private void Start()
	{
	}

	[Token(Token = "0x600411B")]
	[Address(RVA = "0x165F918", Offset = "0x165F918", VA = "0x165F918")]
	private void Update()
	{
	}

	[Token(Token = "0x600411C")]
	[Address(RVA = "0x165F994", Offset = "0x165F994", VA = "0x165F994")]
	public RotateToVelocity()
	{
	}
}
