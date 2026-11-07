using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200006A")]
public class IgnoreCollisionsSimple2D : MonoBehaviour
{
	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject Root;

	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Collider2D[] IgnoreWith;

	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool ignore;

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x14E5B1C", Offset = "0x14E5B1C", VA = "0x14E5B1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x14E5CC0", Offset = "0x14E5CC0", VA = "0x14E5CC0")]
	public IgnoreCollisionsSimple2D()
	{
	}
}
