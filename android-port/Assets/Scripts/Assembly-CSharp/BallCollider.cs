using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200075F")]
public class BallCollider : MonoBehaviour
{
	[Token(Token = "0x4002724")]
	[FieldOffset(Offset = "0x18")]
	public Action<Vector3, Vector3, float, Collider2D> OnCollisionEnter;

	[Token(Token = "0x6002201")]
	[Address(RVA = "0x15184C8", Offset = "0x15184C8", VA = "0x15184C8")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002202")]
	[Address(RVA = "0x1518628", Offset = "0x1518628", VA = "0x1518628")]
	public BallCollider()
	{
	}
}
