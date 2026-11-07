using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008AA")]
public class KatamariCactus2D : MonoBehaviour
{
	[Token(Token = "0x4002F9C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LayerMask collectorLayerMask;

	[Token(Token = "0x4002F9D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform model;

	[Token(Token = "0x4002F9E")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D rigidbody2D;

	[Token(Token = "0x4002F9F")]
	[FieldOffset(Offset = "0x0")]
	public static Action<KatamariCactus2D, Rigidbody2D> OnAttach;

	[Token(Token = "0x6002807")]
	[Address(RVA = "0x14FBB28", Offset = "0x14FBB28", VA = "0x14FBB28")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002808")]
	[Address(RVA = "0x14FBBC0", Offset = "0x14FBBC0", VA = "0x14FBBC0")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002809")]
	[Address(RVA = "0x14FBDB4", Offset = "0x14FBDB4", VA = "0x14FBDB4")]
	public KatamariCactus2D()
	{
	}
}
