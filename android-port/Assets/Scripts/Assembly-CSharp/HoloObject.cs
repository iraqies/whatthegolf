using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A37")]
public class HoloObject : GolfBehaviour
{
	[Token(Token = "0x2000A38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42B80", Offset = "0x42B80")]
	private sealed class _003CHoloBlink_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003866")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003867")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003868")]
		[FieldOffset(Offset = "0x20")]
		public HoloObject _003C_003E4__this;

		[Token(Token = "0x4003869")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x400386A")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Cc_003E5__3;

		[Token(Token = "0x17000509")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60030A9")]
			[Address(RVA = "0x17BF668", Offset = "0x17BF668", VA = "0x17BF668", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700050A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60030AB")]
			[Address(RVA = "0x17BF6B0", Offset = "0x17BF6B0", VA = "0x17BF6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60030A6")]
		[Address(RVA = "0x17BF444", Offset = "0x17BF444", VA = "0x17BF444")]
		[DebuggerHidden]
		public _003CHoloBlink_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60030A7")]
		[Address(RVA = "0x17BF470", Offset = "0x17BF470", VA = "0x17BF470", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60030A8")]
		[Address(RVA = "0x17BF474", Offset = "0x17BF474", VA = "0x17BF474", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60030A9")]
		[Address(RVA = "0x17BF668", Offset = "0x17BF668", VA = "0x17BF668", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60030AA")]
		[Address(RVA = "0x17BF670", Offset = "0x17BF670", VA = "0x17BF670", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60030AB")]
		[Address(RVA = "0x17BF6B0", Offset = "0x17BF6B0", VA = "0x17BF6B0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003864")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer sprite;

	[Token(Token = "0x4003865")]
	[FieldOffset(Offset = "0x28")]
	private bool isAnimating;

	[Token(Token = "0x60030A1")]
	[Address(RVA = "0x14D3EEC", Offset = "0x14D3EEC", VA = "0x14D3EEC", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x60030A2")]
	[Address(RVA = "0x14D3F64", Offset = "0x14D3F64", VA = "0x14D3F64")]
	private void Awake()
	{
	}

	[Token(Token = "0x60030A3")]
	[Address(RVA = "0x14D3F84", Offset = "0x14D3F84", VA = "0x14D3F84")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60030A4")]
	[Address(RVA = "0x14D4018", Offset = "0x14D4018", VA = "0x14D4018")]
	private IEnumerator HoloBlink()
	{
		return null;
	}

	[Token(Token = "0x60030A5")]
	[Address(RVA = "0x14D408C", Offset = "0x14D408C", VA = "0x14D408C")]
	public HoloObject()
	{
	}
}
