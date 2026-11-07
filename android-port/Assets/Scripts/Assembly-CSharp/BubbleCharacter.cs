using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005DB")]
public class BubbleCharacter : MonoBehaviour
{
	[Token(Token = "0x4001DD2")]
	[FieldOffset(Offset = "0x18")]
	public ShadowProjector2D shadowProjector;

	[Token(Token = "0x4001DD3")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody2D rigidbody2D;

	[Token(Token = "0x4001DD4")]
	[FieldOffset(Offset = "0x28")]
	private Collider2D[] colliders;

	[Token(Token = "0x6001AB3")]
	[Address(RVA = "0x170A6FC", Offset = "0x170A6FC", VA = "0x170A6FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001AB4")]
	[Address(RVA = "0x170A3F4", Offset = "0x170A3F4", VA = "0x170A3F4")]
	public void Pickup()
	{
	}

	[Token(Token = "0x6001AB5")]
	[Address(RVA = "0x170A7C0", Offset = "0x170A7C0", VA = "0x170A7C0")]
	public void Release()
	{
	}

	[Token(Token = "0x6001AB6")]
	[Address(RVA = "0x170A8D4", Offset = "0x170A8D4", VA = "0x170A8D4")]
	public BubbleCharacter()
	{
	}
}
