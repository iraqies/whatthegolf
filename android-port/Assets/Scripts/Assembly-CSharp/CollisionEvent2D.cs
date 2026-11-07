using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200087F")]
public class CollisionEvent2D : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000880")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41B20", Offset = "0x41B20")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002E9A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002E9B")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__16_0;

		[Token(Token = "0x6002740")]
		[Address(RVA = "0x178E338", Offset = "0x178E338", VA = "0x178E338")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002741")]
		[Address(RVA = "0x178E340", Offset = "0x178E340", VA = "0x178E340")]
		internal void _003CEnterInvoke_003Eb__16_0(float t)
		{
		}
	}

	[Token(Token = "0x4002E90")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnEnter;

	[Token(Token = "0x4002E91")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent OnStay;

	[Token(Token = "0x4002E92")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent OnExit;

	[Token(Token = "0x4002E93")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent OnTriggerEnter;

	[Token(Token = "0x4002E94")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent OnTriggerStay;

	[Token(Token = "0x4002E95")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent OnTriggerExit;

	[Token(Token = "0x4002E96")]
	[FieldOffset(Offset = "0x48")]
	public List<string> Tags;

	[Token(Token = "0x4002E97")]
	[FieldOffset(Offset = "0x50")]
	public float minForce;

	[Token(Token = "0x4002E98")]
	[FieldOffset(Offset = "0x54")]
	public bool acceptAny;

	[Token(Token = "0x4002E99")]
	[FieldOffset(Offset = "0x58")]
	public float Delay;

	[Token(Token = "0x6002735")]
	[Address(RVA = "0x18A80A8", Offset = "0x18A80A8", VA = "0x18A80A8")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x6002736")]
	[Address(RVA = "0x18A8390", Offset = "0x18A8390", VA = "0x18A8390")]
	private void OnCollisionStay2D(Collision2D other)
	{
	}

	[Token(Token = "0x6002737")]
	[Address(RVA = "0x18A84A8", Offset = "0x18A84A8", VA = "0x18A84A8")]
	private void OnCollisionExit2D(Collision2D other)
	{
	}

	[Token(Token = "0x6002738")]
	[Address(RVA = "0x18A85DC", Offset = "0x18A85DC", VA = "0x18A85DC")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6002739")]
	[Address(RVA = "0x18A869C", Offset = "0x18A869C", VA = "0x18A869C")]
	private void OnTriggerStay2D(Collider2D other)
	{
	}

	[Token(Token = "0x600273A")]
	[Address(RVA = "0x18A875C", Offset = "0x18A875C", VA = "0x18A875C")]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[Token(Token = "0x600273B")]
	[Address(RVA = "0x18A81B8", Offset = "0x18A81B8", VA = "0x18A81B8")]
	private void EnterInvoke()
	{
	}

	[Token(Token = "0x600273C")]
	[Address(RVA = "0x18A85C0", Offset = "0x18A85C0", VA = "0x18A85C0")]
	private void ExitInvoke()
	{
	}

	[Token(Token = "0x600273D")]
	[Address(RVA = "0x18A881C", Offset = "0x18A881C", VA = "0x18A881C")]
	public CollisionEvent2D()
	{
	}

	[Token(Token = "0x600273E")]
	[Address(RVA = "0x18A8824", Offset = "0x18A8824", VA = "0x18A8824")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66E90", Offset = "0x66E90")]
	private void _003CEnterInvoke_003Eb__16_1()
	{
	}
}
