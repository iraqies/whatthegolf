using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000048")]
public class XmasHeader : MonoBehaviour
{
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D3A8", Offset = "0x3D3A8")]
	private sealed class _003CHideRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x20")]
		public XmasHeader _003C_003E4__this;

		[Token(Token = "0x17000036")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x187DCE0", Offset = "0x187DCE0", VA = "0x187DCE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000037")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x187DD28", Offset = "0x187DD28", VA = "0x187DD28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x187DBB4", Offset = "0x187DBB4", VA = "0x187DBB4")]
		[DebuggerHidden]
		public _003CHideRoutine_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x187DBE0", Offset = "0x187DBE0", VA = "0x187DBE0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x187DBE4", Offset = "0x187DBE4", VA = "0x187DBE4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x187DCE0", Offset = "0x187DCE0", VA = "0x187DCE0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x187DCE8", Offset = "0x187DCE8", VA = "0x187DCE8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x187DD28", Offset = "0x187DD28", VA = "0x187DD28", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform Container;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform Landscape;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform LandscapeContainer;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform LandscapeRotated;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform LandscapeRotatedContainer;

	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x40")]
	public RectTransform Portrait;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x48")]
	public RectTransform PortraitContainer;

	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x50")]
	public Canvas Canvas;

	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x58")]
	public List<GameObject> FakeButtons;

	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x60")]
	private RectTransform activeRect;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x17615C0", Offset = "0x17615C0", VA = "0x17615C0")]
	public void ShowInMenu()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x17618C8", Offset = "0x17618C8", VA = "0x17618C8")]
	public void ToggleHeader(LevelData.WindowType window)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1761D48", Offset = "0x1761D48", VA = "0x1761D48")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1761DC4", Offset = "0x1761DC4", VA = "0x1761DC4")]
	private IEnumerator HideRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1761E38", Offset = "0x1761E38", VA = "0x1761E38")]
	public XmasHeader()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1761E40", Offset = "0x1761E40", VA = "0x1761E40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D2E4", Offset = "0x5D2E4")]
	private void _003CShowInMenu_003Eb__10_0(float t)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1761EB8", Offset = "0x1761EB8", VA = "0x1761EB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D2F4", Offset = "0x5D2F4")]
	private void _003CToggleHeader_003Eb__11_0(float t)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1761F30", Offset = "0x1761F30", VA = "0x1761F30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D304", Offset = "0x5D304")]
	private void _003CHideRoutine_003Eb__13_0(float t)
	{
	}
}
