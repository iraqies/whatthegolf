using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200058C")]
public class UnlockCollectable : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200058D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4066C", Offset = "0x4066C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001C65")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001C66")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__2_0;

		[Token(Token = "0x600194A")]
		[Address(RVA = "0x18724E8", Offset = "0x18724E8", VA = "0x18724E8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600194B")]
		[Address(RVA = "0x18724F0", Offset = "0x18724F0", VA = "0x18724F0")]
		internal void _003COnTriggerEnter2D_003Eb__2_0(float t)
		{
		}
	}

	[Token(Token = "0x4001C63")]
	[FieldOffset(Offset = "0x18")]
	public Collectable CollectableToUnlock;

	[Token(Token = "0x4001C64")]
	[FieldOffset(Offset = "0x20")]
	public GameObject UnlockedIndicator;

	[Token(Token = "0x6001945")]
	[Address(RVA = "0x173C2B0", Offset = "0x173C2B0", VA = "0x173C2B0")]
	private void OnTriggerEnter2D(Collider2D collider)
	{
	}

	[Token(Token = "0x6001946")]
	[Address(RVA = "0x173C4C8", Offset = "0x173C4C8", VA = "0x173C4C8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001947")]
	[Address(RVA = "0x173C4E8", Offset = "0x173C4E8", VA = "0x173C4E8")]
	public UnlockCollectable()
	{
	}

	[Token(Token = "0x6001948")]
	[Address(RVA = "0x173C4F0", Offset = "0x173C4F0", VA = "0x173C4F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63440", Offset = "0x63440")]
	private void _003COnTriggerEnter2D_003Eb__2_1()
	{
	}
}
