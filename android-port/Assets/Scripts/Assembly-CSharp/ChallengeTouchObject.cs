using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000449")]
public class ChallengeTouchObject : MonoBehaviour
{
	[Token(Token = "0x4001756")]
	[FieldOffset(Offset = "0x18")]
	public Action<ChallengeTouchObject> onToughTarget;

	[Token(Token = "0x4001757")]
	[FieldOffset(Offset = "0x20")]
	private GameObject _toughTarget;

	[Token(Token = "0x600141A")]
	[Address(RVA = "0x18953E0", Offset = "0x18953E0", VA = "0x18953E0")]
	public void SetTouchTarget(GameObject target)
	{
	}

	[Token(Token = "0x600141B")]
	[Address(RVA = "0x18953E8", Offset = "0x18953E8", VA = "0x18953E8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600141C")]
	[Address(RVA = "0x18954BC", Offset = "0x18954BC", VA = "0x18954BC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600141D")]
	[Address(RVA = "0x1895590", Offset = "0x1895590", VA = "0x1895590")]
	public ChallengeTouchObject()
	{
	}
}
