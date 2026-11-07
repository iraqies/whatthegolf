using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200075B")]
public class AutoRestart : MonoBehaviour
{
	[Token(Token = "0x200075C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x413A8", Offset = "0x413A8")]
	private sealed class _003CStart_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002716")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002717")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002718")]
		[FieldOffset(Offset = "0x20")]
		private float _003CmaxWait_003E5__2;

		[Token(Token = "0x170003C3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60021F7")]
			[Address(RVA = "0x17706BC", Offset = "0x17706BC", VA = "0x17706BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003C4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60021F9")]
			[Address(RVA = "0x1770704", Offset = "0x1770704", VA = "0x1770704", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60021F4")]
		[Address(RVA = "0x1770554", Offset = "0x1770554", VA = "0x1770554")]
		[DebuggerHidden]
		public _003CStart_003Ed__0(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60021F5")]
		[Address(RVA = "0x1770580", Offset = "0x1770580", VA = "0x1770580", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60021F6")]
		[Address(RVA = "0x1770584", Offset = "0x1770584", VA = "0x1770584", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60021F7")]
		[Address(RVA = "0x17706BC", Offset = "0x17706BC", VA = "0x17706BC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60021F8")]
		[Address(RVA = "0x17706C4", Offset = "0x17706C4", VA = "0x17706C4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60021F9")]
		[Address(RVA = "0x1770704", Offset = "0x1770704", VA = "0x1770704", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x60021F2")]
	[Address(RVA = "0x1515110", Offset = "0x1515110", VA = "0x1515110")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60021F3")]
	[Address(RVA = "0x151516C", Offset = "0x151516C", VA = "0x151516C")]
	public AutoRestart()
	{
	}
}
