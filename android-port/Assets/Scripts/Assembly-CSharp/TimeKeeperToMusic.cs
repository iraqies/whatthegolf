using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000848")]
public class TimeKeeperToMusic : MonoBehaviour
{
	[Token(Token = "0x2000849")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41998", Offset = "0x41998")]
	private sealed class _003CStart_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002CE8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002CE9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002CEA")]
		[FieldOffset(Offset = "0x20")]
		public TimeKeeperToMusic _003C_003E4__this;

		[Token(Token = "0x17000423")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600263C")]
			[Address(RVA = "0x1867350", Offset = "0x1867350", VA = "0x1867350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000424")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600263E")]
			[Address(RVA = "0x1867398", Offset = "0x1867398", VA = "0x1867398", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002639")]
		[Address(RVA = "0x1867198", Offset = "0x1867198", VA = "0x1867198")]
		[DebuggerHidden]
		public _003CStart_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600263A")]
		[Address(RVA = "0x18671C4", Offset = "0x18671C4", VA = "0x18671C4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600263B")]
		[Address(RVA = "0x18671C8", Offset = "0x18671C8", VA = "0x18671C8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600263C")]
		[Address(RVA = "0x1867350", Offset = "0x1867350", VA = "0x1867350", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600263D")]
		[Address(RVA = "0x1867358", Offset = "0x1867358", VA = "0x1867358", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600263E")]
		[Address(RVA = "0x1867398", Offset = "0x1867398", VA = "0x1867398", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002CE7")]
	[FieldOffset(Offset = "0x18")]
	private Level level;

	[Token(Token = "0x6002635")]
	[Address(RVA = "0x17160E0", Offset = "0x17160E0", VA = "0x17160E0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6002636")]
	[Address(RVA = "0x1716154", Offset = "0x1716154", VA = "0x1716154")]
	private void Music_OnIntialized()
	{
	}

	[Token(Token = "0x6002637")]
	[Address(RVA = "0x171620C", Offset = "0x171620C", VA = "0x171620C")]
	private void Update()
	{
	}

	[Token(Token = "0x6002638")]
	[Address(RVA = "0x17162EC", Offset = "0x17162EC", VA = "0x17162EC")]
	public TimeKeeperToMusic()
	{
	}
}
