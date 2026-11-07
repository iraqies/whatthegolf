using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C06")]
public class LookInDirection2D : MonoBehaviour
{
	[Token(Token = "0x4004291")]
	[FieldOffset(Offset = "0x18")]
	public Transform LookTransform;

	[Token(Token = "0x4004292")]
	[FieldOffset(Offset = "0x20")]
	public float RotateSpeed;

	[Token(Token = "0x4004293")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D rigid;

	[Token(Token = "0x60039B4")]
	[Address(RVA = "0x154BAB0", Offset = "0x154BAB0", VA = "0x154BAB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60039B5")]
	[Address(RVA = "0x154BB0C", Offset = "0x154BB0C", VA = "0x154BB0C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60039B6")]
	[Address(RVA = "0x154BC50", Offset = "0x154BC50", VA = "0x154BC50")]
	public LookInDirection2D()
	{
	}
}
