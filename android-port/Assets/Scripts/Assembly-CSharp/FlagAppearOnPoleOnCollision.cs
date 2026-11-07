using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000224")]
public class FlagAppearOnPoleOnCollision : MonoBehaviour
{
	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask HitLayers;

	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x20")]
	public Animator FlagAnimator;

	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x28")]
	public Action<FlagAppearOnPoleOnCollision> OnFlagAppeared;

	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x30")]
	private bool hasAppeared;

	[Token(Token = "0x6000991")]
	[Address(RVA = "0x1469DF8", Offset = "0x1469DF8", VA = "0x1469DF8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000992")]
	[Address(RVA = "0x1469EF8", Offset = "0x1469EF8", VA = "0x1469EF8")]
	public FlagAppearOnPoleOnCollision()
	{
	}
}
