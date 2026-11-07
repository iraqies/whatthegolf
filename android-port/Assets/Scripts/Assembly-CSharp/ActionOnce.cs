using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E64")]
public class ActionOnce : MonoBehaviour
{
	[Token(Token = "0x2000E65")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45048", Offset = "0x45048")]
	private sealed class _003CDo_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004DF7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004DF8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004DF9")]
		[FieldOffset(Offset = "0x20")]
		public ActionOnce _003C_003E4__this;

		[Token(Token = "0x170006E8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004356")]
			[Address(RVA = "0x17688C4", Offset = "0x17688C4", VA = "0x17688C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006E9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004358")]
			[Address(RVA = "0x176890C", Offset = "0x176890C", VA = "0x176890C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004353")]
		[Address(RVA = "0x17687C8", Offset = "0x17687C8", VA = "0x17687C8")]
		[DebuggerHidden]
		public _003CDo_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004354")]
		[Address(RVA = "0x17687F4", Offset = "0x17687F4", VA = "0x17687F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004355")]
		[Address(RVA = "0x17687F8", Offset = "0x17687F8", VA = "0x17687F8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004356")]
		[Address(RVA = "0x17688C4", Offset = "0x17688C4", VA = "0x17688C4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004357")]
		[Address(RVA = "0x17688CC", Offset = "0x17688CC", VA = "0x17688CC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004358")]
		[Address(RVA = "0x176890C", Offset = "0x176890C", VA = "0x176890C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004DF3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float delay;

	[Token(Token = "0x4004DF4")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool startOnEnable;

	[Token(Token = "0x4004DF5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvent m_Event;

	[Token(Token = "0x4004DF6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool hasHappened;

	[Token(Token = "0x600434F")]
	[Address(RVA = "0x1404940", Offset = "0x1404940", VA = "0x1404940")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004350")]
	[Address(RVA = "0x14049E0", Offset = "0x14049E0", VA = "0x14049E0")]
	public void DoAction()
	{
	}

	[Token(Token = "0x6004351")]
	[Address(RVA = "0x1404A74", Offset = "0x1404A74", VA = "0x1404A74")]
	private IEnumerator Do()
	{
		return null;
	}

	[Token(Token = "0x6004352")]
	[Address(RVA = "0x1404AE8", Offset = "0x1404AE8", VA = "0x1404AE8")]
	public ActionOnce()
	{
	}
}
