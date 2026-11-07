using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BA4")]
public class TransitionTester : MonoBehaviour
{
	[Token(Token = "0x2000BA5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43BB0", Offset = "0x43BB0")]
	private sealed class _003CKillCR_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40040FE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40040FF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004100")]
		[FieldOffset(Offset = "0x20")]
		public TransitionTester _003C_003E4__this;

		[Token(Token = "0x170005EB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003840")]
			[Address(RVA = "0x186BDD8", Offset = "0x186BDD8", VA = "0x186BDD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005EC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003842")]
			[Address(RVA = "0x186BE20", Offset = "0x186BE20", VA = "0x186BE20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600383D")]
		[Address(RVA = "0x186BD1C", Offset = "0x186BD1C", VA = "0x186BD1C")]
		[DebuggerHidden]
		public _003CKillCR_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600383E")]
		[Address(RVA = "0x186BD48", Offset = "0x186BD48", VA = "0x186BD48", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600383F")]
		[Address(RVA = "0x186BD4C", Offset = "0x186BD4C", VA = "0x186BD4C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003840")]
		[Address(RVA = "0x186BDD8", Offset = "0x186BDD8", VA = "0x186BDD8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003841")]
		[Address(RVA = "0x186BDE0", Offset = "0x186BDE0", VA = "0x186BDE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003842")]
		[Address(RVA = "0x186BE20", Offset = "0x186BE20", VA = "0x186BE20", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40040FC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transition _transition;

	[Token(Token = "0x40040FD")]
	[FieldOffset(Offset = "0x20")]
	private Coroutine _cr;

	[Token(Token = "0x6003839")]
	[Address(RVA = "0x172C5D8", Offset = "0x172C5D8", VA = "0x172C5D8")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6AFDC", Offset = "0x6AFDC")]
	public void TestInterruptionStart()
	{
	}

	[Token(Token = "0x600383A")]
	[Address(RVA = "0x172C7E4", Offset = "0x172C7E4", VA = "0x172C7E4")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6B014", Offset = "0x6B014")]
	public void TestInterruptionEnd()
	{
	}

	[Token(Token = "0x600383B")]
	[Address(RVA = "0x172C770", Offset = "0x172C770", VA = "0x172C770")]
	private IEnumerator KillCR()
	{
		return null;
	}

	[Token(Token = "0x600383C")]
	[Address(RVA = "0x172C8CC", Offset = "0x172C8CC", VA = "0x172C8CC")]
	public TransitionTester()
	{
	}
}
