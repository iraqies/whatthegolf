using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001BB")]
public class PopupController : MonoBehaviour
{
	[Token(Token = "0x20001BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E010", Offset = "0x3E010")]
	private sealed class _003COnCloseCR_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007C5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x20")]
		public PopupController _003C_003E4__this;

		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x28")]
		public bool confirmed;

		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x29")]
		public bool invokeCallbacks;

		[Token(Token = "0x17000108")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x182A780", Offset = "0x182A780", VA = "0x182A780", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000109")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x182A7C8", Offset = "0x182A7C8", VA = "0x182A7C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x182A674", Offset = "0x182A674", VA = "0x182A674")]
		[DebuggerHidden]
		public _003COnCloseCR_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x182A6A0", Offset = "0x182A6A0", VA = "0x182A6A0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x182A6A4", Offset = "0x182A6A4", VA = "0x182A6A4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x182A780", Offset = "0x182A780", VA = "0x182A780", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x182A788", Offset = "0x182A788", VA = "0x182A788", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x182A7C8", Offset = "0x182A7C8", VA = "0x182A7C8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected AnimateRectTransform container;

	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected AdventureButton play;

	[Token(Token = "0x40007C3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected Button close;

	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0x30")]
	private bool showing;

	[Token(Token = "0x17000107")]
	public bool IsShowing
	{
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x161A428", Offset = "0x161A428", VA = "0x161A428")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60007A7")]
	[Address(RVA = "0x161A430", Offset = "0x161A430", VA = "0x161A430")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60007A8")]
	[Address(RVA = "0x161A524", Offset = "0x161A524", VA = "0x161A524")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x161A570", Offset = "0x161A570", VA = "0x161A570")]
	public void Show()
	{
	}

	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x161A6F8", Offset = "0x161A6F8", VA = "0x161A6F8")]
	public void Hide(bool confirmed, bool invokeCallbacks)
	{
	}

	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x161A5E4", Offset = "0x161A5E4", VA = "0x161A5E4")]
	private void Open()
	{
	}

	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x161A81C", Offset = "0x161A81C", VA = "0x161A81C")]
	private void Play()
	{
	}

	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x161A778", Offset = "0x161A778", VA = "0x161A778")]
	private void Close(bool confirmed, bool invokeCallbacks)
	{
	}

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x161A900", Offset = "0x161A900", VA = "0x161A900")]
	private IEnumerator OnCloseCR(bool confirmed, bool invokeCallbacks)
	{
		return null;
	}

	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x161A98C", Offset = "0x161A98C", VA = "0x161A98C", Slot = "4")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x161AC90", Offset = "0x161AC90", VA = "0x161AC90", Slot = "5")]
	protected virtual void OnOpen()
	{
	}

	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x161AC94", Offset = "0x161AC94", VA = "0x161AC94", Slot = "6")]
	protected virtual void OnClosing()
	{
	}

	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x161AC98", Offset = "0x161AC98", VA = "0x161AC98", Slot = "7")]
	protected virtual void OnClose(bool confirmed, bool invokeCallbacks)
	{
	}

	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x161AC9C", Offset = "0x161AC9C", VA = "0x161AC9C", Slot = "8")]
	protected virtual void OnPlay()
	{
	}

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x161ACA0", Offset = "0x161ACA0", VA = "0x161ACA0")]
	public PopupController()
	{
	}

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x161ACA8", Offset = "0x161ACA8", VA = "0x161ACA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F27C", Offset = "0x5F27C")]
	private void _003COnEnable_003Eb__6_0()
	{
	}
}
