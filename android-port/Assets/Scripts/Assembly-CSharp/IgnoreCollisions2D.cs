using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B0D")]
public class IgnoreCollisions2D : MonoBehaviour
{
	[Token(Token = "0x4003DC0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject rootA;

	[Token(Token = "0x4003DC1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Collider2D> rootAblackList;

	[Token(Token = "0x4003DC2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject rootB;

	[Token(Token = "0x4003DC3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Collider2D> rootBblacklist;

	[Token(Token = "0x4003DC4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool ignoreCollisions;

	[Token(Token = "0x60034C6")]
	[Address(RVA = "0x14E5900", Offset = "0x14E5900", VA = "0x14E5900")]
	private void Awake()
	{
	}

	[Token(Token = "0x60034C7")]
	[Address(RVA = "0x14E5B0C", Offset = "0x14E5B0C", VA = "0x14E5B0C")]
	public IgnoreCollisions2D()
	{
	}
}
