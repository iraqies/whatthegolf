using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A3B")]
public class OverworldFanButtonActivator : MonoBehaviour
{
	[Token(Token = "0x4003882")]
	[FieldOffset(Offset = "0x18")]
	public float brakeOnButton;

	[Token(Token = "0x4003883")]
	[FieldOffset(Offset = "0x1C")]
	public bool isOnButton;

	[Token(Token = "0x4003884")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody2D rigid;

	[Token(Token = "0x60030BF")]
	[Address(RVA = "0x15B7420", Offset = "0x15B7420", VA = "0x15B7420")]
	private void Awake()
	{
	}

	[Token(Token = "0x60030C0")]
	[Address(RVA = "0x15B747C", Offset = "0x15B747C", VA = "0x15B747C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60030C1")]
	[Address(RVA = "0x15B7578", Offset = "0x15B7578", VA = "0x15B7578")]
	public OverworldFanButtonActivator()
	{
	}
}
