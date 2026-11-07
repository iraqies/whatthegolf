using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200078D")]
public class RotatingWall : MonoBehaviour
{
	[Token(Token = "0x40027EE")]
	[FieldOffset(Offset = "0x18")]
	public float rotationSpeed;

	[Token(Token = "0x40027EF")]
	[FieldOffset(Offset = "0x1C")]
	public float angleOffset;

	[Token(Token = "0x40027F0")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody2D rigid;

	[Token(Token = "0x60022AA")]
	[Address(RVA = "0x166167C", Offset = "0x166167C", VA = "0x166167C")]
	private void Start()
	{
	}

	[Token(Token = "0x60022AB")]
	[Address(RVA = "0x16616E8", Offset = "0x16616E8", VA = "0x16616E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60022AC")]
	[Address(RVA = "0x166170C", Offset = "0x166170C", VA = "0x166170C")]
	public RotatingWall()
	{
	}
}
