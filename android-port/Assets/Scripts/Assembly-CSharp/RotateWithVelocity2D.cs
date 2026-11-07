using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B25")]
public class RotateWithVelocity2D : MonoBehaviour
{
	[Token(Token = "0x4003E55")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody2D Rigidbody;

	[Token(Token = "0x4003E56")]
	[FieldOffset(Offset = "0x20")]
	public float RotateSpeed;

	[Token(Token = "0x4003E57")]
	[FieldOffset(Offset = "0x24")]
	public bool UsePhysics;

	[Token(Token = "0x4003E58")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D _rigid;

	[Token(Token = "0x6003524")]
	[Address(RVA = "0x166091C", Offset = "0x166091C", VA = "0x166091C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003525")]
	[Address(RVA = "0x16609C8", Offset = "0x16609C8", VA = "0x16609C8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003526")]
	[Address(RVA = "0x1660B40", Offset = "0x1660B40", VA = "0x1660B40")]
	public RotateWithVelocity2D()
	{
	}
}
