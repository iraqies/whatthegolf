using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005F6")]
public class BillardHole : MonoBehaviour
{
	[Token(Token = "0x4001E73")]
	[FieldOffset(Offset = "0x18")]
	public BilliardGolf BilliardParent;

	[Token(Token = "0x4001E74")]
	[FieldOffset(Offset = "0x20")]
	public bool DestroyBall;

	[Token(Token = "0x4001E75")]
	[FieldOffset(Offset = "0x21")]
	public bool OnlyPlayerBall;

	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0x1610D80", Offset = "0x1610D80", VA = "0x1610D80")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0x1610ED0", Offset = "0x1610ED0", VA = "0x1610ED0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6001B1E")]
	[Address(RVA = "0x1610F48", Offset = "0x1610F48", VA = "0x1610F48")]
	public BillardHole()
	{
	}
}
