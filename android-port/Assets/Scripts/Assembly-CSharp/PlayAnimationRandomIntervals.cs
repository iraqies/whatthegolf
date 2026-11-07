using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DCB")]
public class PlayAnimationRandomIntervals : MonoBehaviour
{
	[Token(Token = "0x2000DCC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D10", Offset = "0x44D10")]
	private sealed class _003CBlink_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004B43")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004B44")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004B45")]
		[FieldOffset(Offset = "0x20")]
		public PlayAnimationRandomIntervals _003C_003E4__this;

		[Token(Token = "0x170006B4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600410F")]
			[Address(RVA = "0x1827904", Offset = "0x1827904", VA = "0x1827904", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006B5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004111")]
			[Address(RVA = "0x182794C", Offset = "0x182794C", VA = "0x182794C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600410C")]
		[Address(RVA = "0x18277DC", Offset = "0x18277DC", VA = "0x18277DC")]
		[DebuggerHidden]
		public _003CBlink_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600410D")]
		[Address(RVA = "0x1827808", Offset = "0x1827808", VA = "0x1827808", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600410E")]
		[Address(RVA = "0x182780C", Offset = "0x182780C", VA = "0x182780C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600410F")]
		[Address(RVA = "0x1827904", Offset = "0x1827904", VA = "0x1827904", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004110")]
		[Address(RVA = "0x182790C", Offset = "0x182790C", VA = "0x182790C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004111")]
		[Address(RVA = "0x182794C", Offset = "0x182794C", VA = "0x182794C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004B3F")]
	[FieldOffset(Offset = "0x18")]
	private Animator animator;

	[Token(Token = "0x4004B40")]
	[FieldOffset(Offset = "0x20")]
	private bool canBlink;

	[Token(Token = "0x4004B41")]
	[FieldOffset(Offset = "0x24")]
	public float minInterval;

	[Token(Token = "0x4004B42")]
	[FieldOffset(Offset = "0x28")]
	public float maxInterval;

	[Token(Token = "0x6004108")]
	[Address(RVA = "0x15E9198", Offset = "0x15E9198", VA = "0x15E9198")]
	private void Start()
	{
	}

	[Token(Token = "0x6004109")]
	[Address(RVA = "0x15E91F4", Offset = "0x15E91F4", VA = "0x15E91F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600410A")]
	[Address(RVA = "0x15E928C", Offset = "0x15E928C", VA = "0x15E928C")]
	private IEnumerator Blink()
	{
		return null;
	}

	[Token(Token = "0x600410B")]
	[Address(RVA = "0x15E9300", Offset = "0x15E9300", VA = "0x15E9300")]
	public PlayAnimationRandomIntervals()
	{
	}
}
