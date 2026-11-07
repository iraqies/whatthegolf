using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009AB")]
public class WinCrownEffect : MonoBehaviour
{
	[Token(Token = "0x20009AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42670", Offset = "0x42670")]
	private sealed class _003CPlayRoutine_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003537")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003538")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003539")]
		[FieldOffset(Offset = "0x20")]
		public WinCrownEffect _003C_003E4__this;

		[Token(Token = "0x400353A")]
		[FieldOffset(Offset = "0x28")]
		public OverworldGoal goal;

		[Token(Token = "0x170004B7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D7F")]
			[Address(RVA = "0x18782AC", Offset = "0x18782AC", VA = "0x18782AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004B8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D81")]
			[Address(RVA = "0x18782F4", Offset = "0x18782F4", VA = "0x18782F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D7C")]
		[Address(RVA = "0x18780DC", Offset = "0x18780DC", VA = "0x18780DC")]
		[DebuggerHidden]
		public _003CPlayRoutine_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D7D")]
		[Address(RVA = "0x1878108", Offset = "0x1878108", VA = "0x1878108", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D7E")]
		[Address(RVA = "0x187810C", Offset = "0x187810C", VA = "0x187810C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002D7F")]
		[Address(RVA = "0x18782AC", Offset = "0x18782AC", VA = "0x18782AC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D80")]
		[Address(RVA = "0x18782B4", Offset = "0x18782B4", VA = "0x18782B4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002D81")]
		[Address(RVA = "0x18782F4", Offset = "0x18782F4", VA = "0x18782F4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003535")]
	[FieldOffset(Offset = "0x18")]
	public Animator Effect;

	[Token(Token = "0x4003536")]
	[FieldOffset(Offset = "0x20")]
	public Transform Container;

	[Token(Token = "0x6002D79")]
	[Address(RVA = "0x17547E8", Offset = "0x17547E8", VA = "0x17547E8")]
	public void Play(OverworldGoal goal)
	{
	}

	[Token(Token = "0x6002D7A")]
	[Address(RVA = "0x1754868", Offset = "0x1754868", VA = "0x1754868")]
	private IEnumerator PlayRoutine(OverworldGoal goal)
	{
		return null;
	}

	[Token(Token = "0x6002D7B")]
	[Address(RVA = "0x17548E0", Offset = "0x17548E0", VA = "0x17548E0")]
	public WinCrownEffect()
	{
	}
}
