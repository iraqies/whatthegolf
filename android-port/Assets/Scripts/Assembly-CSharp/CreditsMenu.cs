using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000550")]
public class CreditsMenu : AddressableSingleton<CreditsMenu>
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000551")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x403D4", Offset = "0x403D4")]
	private struct _003CShowCredits_003Ed__15 : IAsyncStateMachine
	{
		[Token(Token = "0x4001B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4001B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CreditsMenu _003C_003E4__this;

		[Token(Token = "0x4001B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action closeAction;

		[Token(Token = "0x4001B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object _003C_003Eu__1;

		[Token(Token = "0x6001841")]
		[Address(RVA = "0x1791DF0", Offset = "0x1791DF0", VA = "0x1791DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6001842")]
		[Address(RVA = "0x17921C0", Offset = "0x17921C0", VA = "0x17921C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000552")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x403E4", Offset = "0x403E4")]
	private sealed class _003CHideCreditsMenu_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CreditsMenu _003C_003E4__this;

		[Token(Token = "0x170002A9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001846")]
			[Address(RVA = "0x1791DA0", Offset = "0x1791DA0", VA = "0x1791DA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002AA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001848")]
			[Address(RVA = "0x1791DE8", Offset = "0x1791DE8", VA = "0x1791DE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001843")]
		[Address(RVA = "0x1791BAC", Offset = "0x1791BAC", VA = "0x1791BAC")]
		[DebuggerHidden]
		public _003CHideCreditsMenu_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001844")]
		[Address(RVA = "0x1791BD8", Offset = "0x1791BD8", VA = "0x1791BD8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001845")]
		[Address(RVA = "0x1791BDC", Offset = "0x1791BDC", VA = "0x1791BDC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001846")]
		[Address(RVA = "0x1791DA0", Offset = "0x1791DA0", VA = "0x1791DA0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001847")]
		[Address(RVA = "0x1791DA8", Offset = "0x1791DA8", VA = "0x1791DA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001848")]
		[Address(RVA = "0x1791DE8", Offset = "0x1791DE8", VA = "0x1791DE8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001B76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform ContainerTransform;

	[Token(Token = "0x4001B77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CanvasGroup CanvasGroup;

	[Token(Token = "0x4001B78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Animator CloseButtonAnimator;

	[Token(Token = "0x4001B79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ScrollRect CreditScrollRect;

	[Token(Token = "0x4001B7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TMP_Text CreditsLabel;

	[Token(Token = "0x4001B7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextAsset Credits_Apple;

	[Token(Token = "0x4001B7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextAsset Credits_Switch;

	[Token(Token = "0x4001B7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextAsset Credits_Default;

	[Token(Token = "0x4001B7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextAsset Credits_Playstation;

	[Token(Token = "0x4001B7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool allowExit;

	[Token(Token = "0x4001B80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Action backAction;

	[Token(Token = "0x6001838")]
	[Address(RVA = "0x18C165C", Offset = "0x18C165C", VA = "0x18C165C")]
	public void BackButtonClicked()
	{
	}

	[Token(Token = "0x6001839")]
	[Address(RVA = "0x18C1660", Offset = "0x18C1660", VA = "0x18C1660")]
	private void Close()
	{
	}

	[Token(Token = "0x600183A")]
	[Address(RVA = "0x18C179C", Offset = "0x18C179C", VA = "0x18C179C")]
	private void Update()
	{
	}

	[Token(Token = "0x600183B")]
	[Address(RVA = "0x18C18E8", Offset = "0x18C18E8", VA = "0x18C18E8")]
	private string GetCorrectText()
	{
		return null;
	}

	[Token(Token = "0x600183C")]
	[Address(RVA = "0x18C1904", Offset = "0x18C1904", VA = "0x18C1904")]
	public void ShowCredits(Action closeAction)
	{
	}

	[Token(Token = "0x600183D")]
	[Address(RVA = "0x18C1728", Offset = "0x18C1728", VA = "0x18C1728")]
	public IEnumerator HideCreditsMenu()
	{
		return null;
	}

	[Token(Token = "0x600183E")]
	[Address(RVA = "0x18C19A0", Offset = "0x18C19A0", VA = "0x18C19A0")]
	public CreditsMenu()
	{
	}

	[Token(Token = "0x600183F")]
	[Address(RVA = "0x18C19F8", Offset = "0x18C19F8", VA = "0x18C19F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63058", Offset = "0x63058")]
	private void _003CShowCredits_003Eb__15_0(float t)
	{
	}

	[Token(Token = "0x6001840")]
	[Address(RVA = "0x18C1A84", Offset = "0x18C1A84", VA = "0x18C1A84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63068", Offset = "0x63068")]
	private void _003CHideCreditsMenu_003Eb__16_0(float t)
	{
	}
}
