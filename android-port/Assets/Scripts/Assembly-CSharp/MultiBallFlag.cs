using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000434")]
public class MultiBallFlag : MonoBehaviour
{
	[Token(Token = "0x40016F4")]
	[FieldOffset(Offset = "0x18")]
	public Action<GameObject> OnAnyHit;

	[Token(Token = "0x40016F5")]
	[FieldOffset(Offset = "0x20")]
	public Action<GolfBallController> onControllerHit;

	[Token(Token = "0x60013BA")]
	[Address(RVA = "0x1579094", Offset = "0x1579094", VA = "0x1579094")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x15791DC", Offset = "0x15791DC", VA = "0x15791DC")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x60013BC")]
	[Address(RVA = "0x157935C", Offset = "0x157935C", VA = "0x157935C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60013BD")]
	[Address(RVA = "0x1579498", Offset = "0x1579498", VA = "0x1579498")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x60013BE")]
	[Address(RVA = "0x15795C8", Offset = "0x15795C8", VA = "0x15795C8")]
	public MultiBallFlag()
	{
	}
}
