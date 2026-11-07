using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001EC")]
public class CurlingBroom : MonoBehaviour
{
	[Token(Token = "0x4000929")]
	[FieldOffset(Offset = "0x18")]
	public float allowedXMovement;

	[Token(Token = "0x400092A")]
	[FieldOffset(Offset = "0x1C")]
	private float originalX;

	[Token(Token = "0x400092B")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody rbody;

	[Token(Token = "0x600089E")]
	[Address(RVA = "0x18C4310", Offset = "0x18C4310", VA = "0x18C4310")]
	private void Start()
	{
	}

	[Token(Token = "0x600089F")]
	[Address(RVA = "0x18C4380", Offset = "0x18C4380", VA = "0x18C4380")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x18C44C0", Offset = "0x18C44C0", VA = "0x18C44C0")]
	public CurlingBroom()
	{
	}
}
