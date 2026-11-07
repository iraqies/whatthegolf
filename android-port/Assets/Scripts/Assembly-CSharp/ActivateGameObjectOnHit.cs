using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A4C")]
public class ActivateGameObjectOnHit : MonoBehaviour
{
	[Token(Token = "0x2000A4D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42C60", Offset = "0x42C60")]
	private sealed class _003CHandleHit_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40038F1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40038F2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40038F3")]
		[FieldOffset(Offset = "0x20")]
		public ActivateGameObjectOnHit _003C_003E4__this;

		[Token(Token = "0x17000512")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600311A")]
			[Address(RVA = "0x1768A80", Offset = "0x1768A80", VA = "0x1768A80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000513")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600311C")]
			[Address(RVA = "0x1768AC8", Offset = "0x1768AC8", VA = "0x1768AC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003117")]
		[Address(RVA = "0x1768914", Offset = "0x1768914", VA = "0x1768914")]
		[DebuggerHidden]
		public _003CHandleHit_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003118")]
		[Address(RVA = "0x1768940", Offset = "0x1768940", VA = "0x1768940", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003119")]
		[Address(RVA = "0x1768944", Offset = "0x1768944", VA = "0x1768944", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600311A")]
		[Address(RVA = "0x1768A80", Offset = "0x1768A80", VA = "0x1768A80", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600311B")]
		[Address(RVA = "0x1768A88", Offset = "0x1768A88", VA = "0x1768A88", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600311C")]
		[Address(RVA = "0x1768AC8", Offset = "0x1768AC8", VA = "0x1768AC8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40038EA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject daObject;

	[Token(Token = "0x40038EB")]
	[FieldOffset(Offset = "0x20")]
	public List<string> ActivatorTags;

	[Token(Token = "0x40038EC")]
	[FieldOffset(Offset = "0x28")]
	public List<AudioClip> OnHitClip;

	[Token(Token = "0x40038ED")]
	[FieldOffset(Offset = "0x30")]
	public float delay;

	[Token(Token = "0x40038EE")]
	[FieldOffset(Offset = "0x34")]
	public float bounceFactor;

	[Token(Token = "0x40038EF")]
	[FieldOffset(Offset = "0x38")]
	public bool ignoreActivatorTags;

	[Token(Token = "0x40038F0")]
	[FieldOffset(Offset = "0x39")]
	private bool isHandlingHit;

	[Token(Token = "0x6003114")]
	[Address(RVA = "0x1404CAC", Offset = "0x1404CAC", VA = "0x1404CAC")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x6003115")]
	[Address(RVA = "0x1404E8C", Offset = "0x1404E8C", VA = "0x1404E8C")]
	public IEnumerator HandleHit()
	{
		return null;
	}

	[Token(Token = "0x6003116")]
	[Address(RVA = "0x1404F00", Offset = "0x1404F00", VA = "0x1404F00")]
	public ActivateGameObjectOnHit()
	{
	}
}
