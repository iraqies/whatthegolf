using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B88")]
public class ChangeClockAfterTime : MonoBehaviour
{
	[Token(Token = "0x2000B89")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43AE0", Offset = "0x43AE0")]
	private sealed class _003CStart_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400402C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400402D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400402E")]
		[FieldOffset(Offset = "0x20")]
		public ChangeClockAfterTime _003C_003E4__this;

		[Token(Token = "0x170005D7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60037A8")]
			[Address(RVA = "0x1783350", Offset = "0x1783350", VA = "0x1783350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005D8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60037AA")]
			[Address(RVA = "0x1783398", Offset = "0x1783398", VA = "0x1783398", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60037A5")]
		[Address(RVA = "0x1783230", Offset = "0x1783230", VA = "0x1783230")]
		[DebuggerHidden]
		public _003CStart_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60037A6")]
		[Address(RVA = "0x178325C", Offset = "0x178325C", VA = "0x178325C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60037A7")]
		[Address(RVA = "0x1783260", Offset = "0x1783260", VA = "0x1783260", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60037A8")]
		[Address(RVA = "0x1783350", Offset = "0x1783350", VA = "0x1783350", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60037A9")]
		[Address(RVA = "0x1783358", Offset = "0x1783358", VA = "0x1783358", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60037AA")]
		[Address(RVA = "0x1783398", Offset = "0x1783398", VA = "0x1783398", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004029")]
	[FieldOffset(Offset = "0x18")]
	public string newClockName;

	[Token(Token = "0x400402A")]
	[FieldOffset(Offset = "0x20")]
	public float SetClockAfterRealTime;

	[Token(Token = "0x400402B")]
	[FieldOffset(Offset = "0x28")]
	private TrafficController traffic;

	[Token(Token = "0x60037A3")]
	[Address(RVA = "0x18965D0", Offset = "0x18965D0", VA = "0x18965D0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60037A4")]
	[Address(RVA = "0x1896644", Offset = "0x1896644", VA = "0x1896644")]
	public ChangeClockAfterTime()
	{
	}
}
