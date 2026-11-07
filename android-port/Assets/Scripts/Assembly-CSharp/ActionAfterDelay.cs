using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200032D")]
public class ActionAfterDelay : MonoBehaviour
{
	[Token(Token = "0x200032E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F030", Offset = "0x3F030")]
	private sealed class _003CDo_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40011A1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40011A2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40011A3")]
		[FieldOffset(Offset = "0x20")]
		public ActionAfterDelay _003C_003E4__this;

		[Token(Token = "0x170001BD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000EB2")]
			[Address(RVA = "0x176866C", Offset = "0x176866C", VA = "0x176866C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001BE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000EB4")]
			[Address(RVA = "0x17686B4", Offset = "0x17686B4", VA = "0x17686B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x1768574", Offset = "0x1768574", VA = "0x1768574")]
		[DebuggerHidden]
		public _003CDo_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x17685A0", Offset = "0x17685A0", VA = "0x17685A0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x17685A4", Offset = "0x17685A4", VA = "0x17685A4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x176866C", Offset = "0x176866C", VA = "0x176866C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x1768674", Offset = "0x1768674", VA = "0x1768674", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x17686B4", Offset = "0x17686B4", VA = "0x17686B4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400119E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float delay;

	[Token(Token = "0x400119F")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool startOnEnable;

	[Token(Token = "0x40011A0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvent m_Event;

	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0x1404420", Offset = "0x1404420", VA = "0x1404420")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0x14044B8", Offset = "0x14044B8", VA = "0x14044B8")]
	public void DoAction()
	{
	}

	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0x1404534", Offset = "0x1404534", VA = "0x1404534")]
	private IEnumerator Do()
	{
		return null;
	}

	[Token(Token = "0x6000EAE")]
	[Address(RVA = "0x14045A8", Offset = "0x14045A8", VA = "0x14045A8")]
	public ActionAfterDelay()
	{
	}
}
