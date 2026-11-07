using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E23")]
public class ParentOnCollision : MonoBehaviour
{
	[Token(Token = "0x4004CBF")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask CollisionMask;

	[Token(Token = "0x4004CC0")]
	[FieldOffset(Offset = "0x1C")]
	private bool hasCollided;

	[Token(Token = "0x6004258")]
	[Address(RVA = "0x15DB624", Offset = "0x15DB624", VA = "0x15DB624")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6004259")]
	[Address(RVA = "0x15DB6EC", Offset = "0x15DB6EC", VA = "0x15DB6EC")]
	public ParentOnCollision()
	{
	}
}
