using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C05")]
[Attribute(Name = "RequireComponent", RVA = "0x43EF8", Offset = "0x43EF8")]
public class LookInAimDirection : MonoBehaviour
{
	[Token(Token = "0x400428E")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 Up;

	[Token(Token = "0x400428F")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D rigid2D;

	[Token(Token = "0x4004290")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigid;

	[Token(Token = "0x60039B1")]
	[Address(RVA = "0x154B828", Offset = "0x154B828", VA = "0x154B828")]
	private void Start()
	{
	}

	[Token(Token = "0x60039B2")]
	[Address(RVA = "0x154B948", Offset = "0x154B948", VA = "0x154B948")]
	private void OnOnAimUpdate(Vector3 boost, bool b)
	{
	}

	[Token(Token = "0x60039B3")]
	[Address(RVA = "0x154BA9C", Offset = "0x154BA9C", VA = "0x154BA9C")]
	public LookInAimDirection()
	{
	}
}
