using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000800")]
public class MovingPlatform : MonoBehaviour
{
	[Token(Token = "0x4002ADE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float distance;

	[Token(Token = "0x4002ADF")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x4002AE0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F084", Offset = "0x4F084")]
	private float normalizedStartPosition;

	[Token(Token = "0x4002AE1")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float startDirection;

	[Token(Token = "0x4002AE2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool useUnscaledTime;

	[Token(Token = "0x4002AE3")]
	[FieldOffset(Offset = "0x2C")]
	private float dir;

	[Token(Token = "0x4002AE4")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 startPos;

	[Token(Token = "0x4002AE5")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody rigid;

	[Token(Token = "0x4002AE6")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody2D rigid2D;

	[Token(Token = "0x4002AE7")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 right;

	[Token(Token = "0x4002AE8")]
	[FieldOffset(Offset = "0x60")]
	public Action OnTurn;

	[Token(Token = "0x60024B8")]
	[Address(RVA = "0x1577A78", Offset = "0x1577A78", VA = "0x1577A78")]
	private void Start()
	{
	}

	[Token(Token = "0x60024B9")]
	[Address(RVA = "0x1577BF8", Offset = "0x1577BF8", VA = "0x1577BF8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60024BA")]
	[Address(RVA = "0x1577F18", Offset = "0x1577F18", VA = "0x1577F18")]
	private void MoveRigid(Vector3 position, bool useMovePosition)
	{
	}

	[Token(Token = "0x60024BB")]
	[Address(RVA = "0x1578118", Offset = "0x1578118", VA = "0x1578118")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60024BC")]
	[Address(RVA = "0x15782E4", Offset = "0x15782E4", VA = "0x15782E4")]
	public MovingPlatform()
	{
	}
}
