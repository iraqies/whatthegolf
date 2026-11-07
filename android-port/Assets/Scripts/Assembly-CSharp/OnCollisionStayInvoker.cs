using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B15")]
public class OnCollisionStayInvoker : MonoBehaviour
{
	[Token(Token = "0x4003E00")]
	[FieldOffset(Offset = "0x18")]
	public Action<Collision> OnCollisionStayEvent;

	[Token(Token = "0x60034EB")]
	[Address(RVA = "0x1599C74", Offset = "0x1599C74", VA = "0x1599C74")]
	private void OnCollisionStay(Collision other)
	{
	}

	[Token(Token = "0x60034EC")]
	[Address(RVA = "0x1599CE4", Offset = "0x1599CE4", VA = "0x1599CE4")]
	public OnCollisionStayInvoker()
	{
	}
}
