using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000056")]
public class DebugTransition : MonoBehaviour
{
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D480", Offset = "0x3D480")]
	private sealed class _003CStartTransition_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x20")]
		public DebugTransition _003C_003E4__this;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x28")]
		private BaseTransitionEffect _003Ct_003E5__2;

		[Token(Token = "0x1700003E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x1799FBC", Offset = "0x1799FBC", VA = "0x1799FBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700003F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x179A004", Offset = "0x179A004", VA = "0x179A004", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1799E24", Offset = "0x1799E24", VA = "0x1799E24")]
		[DebuggerHidden]
		public _003CStartTransition_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1799E50", Offset = "0x1799E50", VA = "0x1799E50", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1799E54", Offset = "0x1799E54", VA = "0x1799E54", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1799FBC", Offset = "0x1799FBC", VA = "0x1799FBC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1799FC4", Offset = "0x1799FC4", VA = "0x1799FC4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x179A004", Offset = "0x179A004", VA = "0x179A004", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x18")]
	public Transition transition;

	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x20")]
	private bool running;

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x18D735C", Offset = "0x18D735C", VA = "0x18D735C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x18D744C", Offset = "0x18D744C", VA = "0x18D744C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x18D73D8", Offset = "0x18D73D8", VA = "0x18D73D8")]
	private IEnumerator StartTransition()
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x18D7454", Offset = "0x18D7454", VA = "0x18D7454")]
	public DebugTransition()
	{
	}
}
