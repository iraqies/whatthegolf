using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000060")]
public class DemoEndMenu : MonoBehaviour
{
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D4C0", Offset = "0x3D4C0")]
	private sealed class _003CLoadMainMenuCR_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x20")]
		public DemoEndMenu _003C_003E4__this;

		[Token(Token = "0x17000044")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x179B8E4", Offset = "0x179B8E4", VA = "0x179B8E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000045")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x179B92C", Offset = "0x179B92C", VA = "0x179B92C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x179B774", Offset = "0x179B774", VA = "0x179B774")]
		[DebuggerHidden]
		public _003CLoadMainMenuCR_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x179B7A0", Offset = "0x179B7A0", VA = "0x179B7A0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x179B7A4", Offset = "0x179B7A4", VA = "0x179B7A4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x179B8E4", Offset = "0x179B8E4", VA = "0x179B8E4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x179B8EC", Offset = "0x179B8EC", VA = "0x179B8EC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x179B92C", Offset = "0x179B92C", VA = "0x179B92C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x18")]
	private bool _loading;

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x18DA3A4", Offset = "0x18DA3A4", VA = "0x18DA3A4")]
	public void Show()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x18DA3CC", Offset = "0x18DA3CC", VA = "0x18DA3CC")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x18DA600", Offset = "0x18DA600", VA = "0x18DA600")]
	public void LoadMainMenu()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x18DA698", Offset = "0x18DA698", VA = "0x18DA698")]
	public IEnumerator LoadMainMenuCR()
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x18DA70C", Offset = "0x18DA70C", VA = "0x18DA70C")]
	public DemoEndMenu()
	{
	}
}
