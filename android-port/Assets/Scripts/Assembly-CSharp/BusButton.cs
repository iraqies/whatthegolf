using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000650")]
public class BusButton : MonoBehaviour
{
	[Token(Token = "0x2000651")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40C00", Offset = "0x40C00")]
	private sealed class _003CClickButtonRoutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40020B9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40020BA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40020BB")]
		[FieldOffset(Offset = "0x20")]
		public BusButton _003C_003E4__this;

		[Token(Token = "0x1700032F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001CD5")]
			[Address(RVA = "0x177C650", Offset = "0x177C650", VA = "0x177C650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000330")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001CD7")]
			[Address(RVA = "0x177C698", Offset = "0x177C698", VA = "0x177C698", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001CD2")]
		[Address(RVA = "0x177C43C", Offset = "0x177C43C", VA = "0x177C43C")]
		[DebuggerHidden]
		public _003CClickButtonRoutine_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001CD3")]
		[Address(RVA = "0x177C468", Offset = "0x177C468", VA = "0x177C468", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001CD4")]
		[Address(RVA = "0x177C46C", Offset = "0x177C46C", VA = "0x177C46C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0x177C650", Offset = "0x177C650", VA = "0x177C650", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001CD6")]
		[Address(RVA = "0x177C658", Offset = "0x177C658", VA = "0x177C658", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001CD7")]
		[Address(RVA = "0x177C698", Offset = "0x177C698", VA = "0x177C698", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40020B4")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip sfxOnClick;

	[Token(Token = "0x40020B5")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E4AC", Offset = "0x4E4AC")]
	private Action m_OnPressed;

	[Token(Token = "0x40020B6")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rigid;

	[Token(Token = "0x40020B7")]
	[FieldOffset(Offset = "0x30")]
	private bool wasPressed;

	[Token(Token = "0x40020B8")]
	[FieldOffset(Offset = "0x38")]
	private FixedJoint joint;

	[Token(Token = "0x1400002C")]
	public event Action OnPressed
	{
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x17D48DC", Offset = "0x17D48DC", VA = "0x17D48DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642CC", Offset = "0x642CC")]
		add
		{
		}
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x17D4980", Offset = "0x17D4980", VA = "0x17D4980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642DC", Offset = "0x642DC")]
		remove
		{
		}
	}

	[Token(Token = "0x6001CCE")]
	[Address(RVA = "0x17D4A24", Offset = "0x17D4A24", VA = "0x17D4A24")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001CCF")]
	[Address(RVA = "0x17D4AA4", Offset = "0x17D4AA4", VA = "0x17D4AA4")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6001CD0")]
	[Address(RVA = "0x17D4B88", Offset = "0x17D4B88", VA = "0x17D4B88")]
	public IEnumerator ClickButtonRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001CD1")]
	[Address(RVA = "0x17D4BFC", Offset = "0x17D4BFC", VA = "0x17D4BFC")]
	public BusButton()
	{
	}
}
