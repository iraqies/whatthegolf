using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200022B")]
public class ChangeDragOnTriggerEnter : MonoBehaviour
{
	[Token(Token = "0x4000B10")]
	[FieldOffset(Offset = "0x18")]
	public Transform FallingObjectsContainer;

	[Token(Token = "0x4000B11")]
	[FieldOffset(Offset = "0x20")]
	public float NewDrag;

	[Token(Token = "0x4000B12")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody[] rigidbodies;

	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x18968D0", Offset = "0x18968D0", VA = "0x18968D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x189692C", Offset = "0x189692C", VA = "0x189692C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x1896A00", Offset = "0x1896A00", VA = "0x1896A00")]
	public ChangeDragOnTriggerEnter()
	{
	}
}
