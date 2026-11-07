using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D6A")]
public class DoEventOnIntervals : MonoBehaviour
{
	[Token(Token = "0x2000D6B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x449B0", Offset = "0x449B0")]
	private sealed class _003CDoEvent_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004908")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004909")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400490A")]
		[FieldOffset(Offset = "0x20")]
		public DoEventOnIntervals _003C_003E4__this;

		[Token(Token = "0x1700066C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003F26")]
			[Address(RVA = "0x179CA08", Offset = "0x179CA08", VA = "0x179CA08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700066D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003F28")]
			[Address(RVA = "0x179CA50", Offset = "0x179CA50", VA = "0x179CA50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003F23")]
		[Address(RVA = "0x179C8F8", Offset = "0x179C8F8", VA = "0x179C8F8")]
		[DebuggerHidden]
		public _003CDoEvent_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003F24")]
		[Address(RVA = "0x179C924", Offset = "0x179C924", VA = "0x179C924", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003F25")]
		[Address(RVA = "0x179C928", Offset = "0x179C928", VA = "0x179C928", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003F26")]
		[Address(RVA = "0x179CA08", Offset = "0x179CA08", VA = "0x179CA08", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003F27")]
		[Address(RVA = "0x179CA10", Offset = "0x179CA10", VA = "0x179CA10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003F28")]
		[Address(RVA = "0x179CA50", Offset = "0x179CA50", VA = "0x179CA50", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004904")]
	[FieldOffset(Offset = "0x18")]
	public bool canFire;

	[Token(Token = "0x4004905")]
	[FieldOffset(Offset = "0x1C")]
	public float minInterval;

	[Token(Token = "0x4004906")]
	[FieldOffset(Offset = "0x20")]
	public float maxInterval;

	[Token(Token = "0x4004907")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent eventToCall;

	[Token(Token = "0x6003F1E")]
	[Address(RVA = "0x142FCB4", Offset = "0x142FCB4", VA = "0x142FCB4")]
	private void Update()
	{
	}

	[Token(Token = "0x6003F1F")]
	[Address(RVA = "0x142FD4C", Offset = "0x142FD4C", VA = "0x142FD4C")]
	private IEnumerator DoEvent()
	{
		return null;
	}

	[Token(Token = "0x6003F20")]
	[Address(RVA = "0x142FDC0", Offset = "0x142FDC0", VA = "0x142FDC0")]
	public void SetBoolTrue()
	{
	}

	[Token(Token = "0x6003F21")]
	[Address(RVA = "0x142FDCC", Offset = "0x142FDCC", VA = "0x142FDCC")]
	public void SetBoolFalse()
	{
	}

	[Token(Token = "0x6003F22")]
	[Address(RVA = "0x142FDD4", Offset = "0x142FDD4", VA = "0x142FDD4")]
	public DoEventOnIntervals()
	{
	}
}
