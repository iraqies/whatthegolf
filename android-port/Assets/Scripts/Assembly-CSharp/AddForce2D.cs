using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ADC")]
public class AddForce2D : MonoBehaviour
{
	[Token(Token = "0x4003C9C")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 direction;

	[Token(Token = "0x4003C9D")]
	[FieldOffset(Offset = "0x20")]
	public float amount;

	[Token(Token = "0x4003C9E")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D _rigidbody2D;

	[Token(Token = "0x4003C9F")]
	[FieldOffset(Offset = "0x30")]
	public ForceMode2D forceMode2D;

	[Token(Token = "0x60033E6")]
	[Address(RVA = "0x1406A34", Offset = "0x1406A34", VA = "0x1406A34")]
	private void Start()
	{
	}

	[Token(Token = "0x60033E7")]
	[Address(RVA = "0x1406A90", Offset = "0x1406A90", VA = "0x1406A90")]
	public void AddForce()
	{
	}

	[Token(Token = "0x60033E8")]
	[Address(RVA = "0x1406AC4", Offset = "0x1406AC4", VA = "0x1406AC4")]
	public AddForce2D()
	{
	}
}
