using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AF7")]
public class CarAntiRoll : MonoBehaviour
{
	[Token(Token = "0x4003D0F")]
	[FieldOffset(Offset = "0x18")]
	public WheelCollider WheelL;

	[Token(Token = "0x4003D10")]
	[FieldOffset(Offset = "0x20")]
	public WheelCollider WheelR;

	[Token(Token = "0x4003D11")]
	[FieldOffset(Offset = "0x28")]
	public float AntiRoll;

	[Token(Token = "0x4003D12")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigidbody;

	[Token(Token = "0x600344B")]
	[Address(RVA = "0x1888A70", Offset = "0x1888A70", VA = "0x1888A70")]
	private void Awake()
	{
	}

	[Token(Token = "0x600344C")]
	[Address(RVA = "0x1888ACC", Offset = "0x1888ACC", VA = "0x1888ACC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600344D")]
	[Address(RVA = "0x1888D28", Offset = "0x1888D28", VA = "0x1888D28")]
	public CarAntiRoll()
	{
	}
}
