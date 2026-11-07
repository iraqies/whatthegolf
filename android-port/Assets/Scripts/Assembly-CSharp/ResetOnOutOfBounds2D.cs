using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000C26")]
public class ResetOnOutOfBounds2D : MonoBehaviour
{
	[Token(Token = "0x4004302")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent AdditionalCalls;

	[Token(Token = "0x4004303")]
	[FieldOffset(Offset = "0x20")]
	public bool UsePlayerOutOfBounds;

	[Token(Token = "0x4004304")]
	[FieldOffset(Offset = "0x24")]
	public float Delay;

	[Token(Token = "0x4004305")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 startPos;

	[Token(Token = "0x4004306")]
	[FieldOffset(Offset = "0x30")]
	private Quaternion startRot;

	[Token(Token = "0x4004307")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody2D rigidbody;

	[Token(Token = "0x6003A1A")]
	[Address(RVA = "0x164B714", Offset = "0x164B714", VA = "0x164B714")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A1B")]
	[Address(RVA = "0x164B82C", Offset = "0x164B82C", VA = "0x164B82C")]
	private void OnReset()
	{
	}

	[Token(Token = "0x6003A1C")]
	[Address(RVA = "0x164B928", Offset = "0x164B928", VA = "0x164B928")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6003A1D")]
	[Address(RVA = "0x164B9F0", Offset = "0x164B9F0", VA = "0x164B9F0")]
	public ResetOnOutOfBounds2D()
	{
	}
}
