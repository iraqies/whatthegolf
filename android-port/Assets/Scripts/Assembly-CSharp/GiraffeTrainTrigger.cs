using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007AD")]
public class GiraffeTrainTrigger : MonoBehaviour
{
	[Token(Token = "0x20007AE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41580", Offset = "0x41580")]
	private sealed class _003CTrainWait_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002887")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002888")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002889")]
		[FieldOffset(Offset = "0x20")]
		public GiraffeTrainTrigger _003C_003E4__this;

		[Token(Token = "0x170003D7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600232E")]
			[Address(RVA = "0x17B4BB4", Offset = "0x17B4BB4", VA = "0x17B4BB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003D8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002330")]
			[Address(RVA = "0x17B4BFC", Offset = "0x17B4BFC", VA = "0x17B4BFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600232B")]
		[Address(RVA = "0x17B49CC", Offset = "0x17B49CC", VA = "0x17B49CC")]
		[DebuggerHidden]
		public _003CTrainWait_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600232C")]
		[Address(RVA = "0x17B49F8", Offset = "0x17B49F8", VA = "0x17B49F8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600232D")]
		[Address(RVA = "0x17B49FC", Offset = "0x17B49FC", VA = "0x17B49FC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600232E")]
		[Address(RVA = "0x17B4BB4", Offset = "0x17B4BB4", VA = "0x17B4BB4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600232F")]
		[Address(RVA = "0x17B4BBC", Offset = "0x17B4BBC", VA = "0x17B4BBC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002330")]
		[Address(RVA = "0x17B4BFC", Offset = "0x17B4BFC", VA = "0x17B4BFC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002886")]
	[FieldOffset(Offset = "0x18")]
	public GiraffeFollow giraffe;

	[Token(Token = "0x6002328")]
	[Address(RVA = "0x148D604", Offset = "0x148D604", VA = "0x148D604")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6002329")]
	[Address(RVA = "0x148D708", Offset = "0x148D708", VA = "0x148D708")]
	private IEnumerator TrainWait()
	{
		return null;
	}

	[Token(Token = "0x600232A")]
	[Address(RVA = "0x148D77C", Offset = "0x148D77C", VA = "0x148D77C")]
	public GiraffeTrainTrigger()
	{
	}
}
