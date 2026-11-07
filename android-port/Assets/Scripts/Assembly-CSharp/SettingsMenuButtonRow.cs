using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000920")]
public class SettingsMenuButtonRow : SettingsMenuCommon
{
	[Token(Token = "0x2000921")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42068", Offset = "0x42068")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x40031E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int value;

		[Token(Token = "0x40031E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SettingsMenuButtonRow _003C_003E4__this;

		[Token(Token = "0x6002A52")]
		[Address(RVA = "0x18484B8", Offset = "0x18484B8", VA = "0x18484B8")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6002A53")]
		[Address(RVA = "0x18484C0", Offset = "0x18484C0", VA = "0x18484C0")]
		internal void _003CInit_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000922")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42078", Offset = "0x42078")]
	private sealed class _003CSetFocusCR_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40031E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40031E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40031E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SettingsMenuButtonRow _003C_003E4__this;

		[Token(Token = "0x17000460")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002A57")]
			[Address(RVA = "0x18485CC", Offset = "0x18485CC", VA = "0x18485CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000461")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A59")]
			[Address(RVA = "0x1848614", Offset = "0x1848614", VA = "0x1848614", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002A54")]
		[Address(RVA = "0x18484E4", Offset = "0x18484E4", VA = "0x18484E4")]
		[DebuggerHidden]
		public _003CSetFocusCR_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002A55")]
		[Address(RVA = "0x1848510", Offset = "0x1848510", VA = "0x1848510", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002A56")]
		[Address(RVA = "0x1848514", Offset = "0x1848514", VA = "0x1848514", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002A57")]
		[Address(RVA = "0x18485CC", Offset = "0x18485CC", VA = "0x18485CC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A58")]
		[Address(RVA = "0x18485D4", Offset = "0x18485D4", VA = "0x18485D4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002A59")]
		[Address(RVA = "0x1848614", Offset = "0x1848614", VA = "0x1848614", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000923")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42088", Offset = "0x42088")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40031E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40031E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<ScrollableButton, bool> _003C_003E9__13_0;

		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x1848440", Offset = "0x1848440", VA = "0x1848440")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002A5C")]
		[Address(RVA = "0x1848448", Offset = "0x1848448", VA = "0x1848448")]
		internal bool _003CSetFocus_003Eb__13_0(ScrollableButton b)
		{
			return default;
		}
	}

	[Token(Token = "0x40031D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<ScrollableButton> buttons;

	[Token(Token = "0x40031D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UnityAction<int> OnChange;

	[Token(Token = "0x40031D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI text;

	[Token(Token = "0x40031DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform focusBox;

	[Token(Token = "0x40031DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform selctedBox;

	[Token(Token = "0x40031DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Func<int> DefaultValue;

	[Token(Token = "0x40031DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Func<int> MaxVisible;

	[Token(Token = "0x40031DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int focusedButtonIndex;

	[Token(Token = "0x40031DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float selectedSwitchDelay;

	[Token(Token = "0x6002A47")]
	[Address(RVA = "0x1697798", Offset = "0x1697798", VA = "0x1697798")]
	public void Init(UnityAction<int> onChange, Func<int> defaultValue, Func<int> maxVisible, bool active, SettingsMenu settings, [Optional] Action init)
	{
	}

	[Token(Token = "0x6002A48")]
	[Address(RVA = "0x169BA00", Offset = "0x169BA00", VA = "0x169BA00")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002A49")]
	[Address(RVA = "0x169BA98", Offset = "0x169BA98", VA = "0x169BA98")]
	private void SetText(int arg0)
	{
	}

	[Token(Token = "0x6002A4A")]
	[Address(RVA = "0x169B98C", Offset = "0x169B98C", VA = "0x169B98C")]
	private IEnumerator SetFocusCR()
	{
		return null;
	}

	[Token(Token = "0x6002A4B")]
	[Address(RVA = "0x169B6C8", Offset = "0x169B6C8", VA = "0x169B6C8")]
	private void SetFocus()
	{
	}

	[Token(Token = "0x6002A4C")]
	[Address(RVA = "0x169BB80", Offset = "0x169BB80", VA = "0x169BB80")]
	private void privateOnChange(int selected)
	{
	}

	[Token(Token = "0x6002A4D")]
	[Address(RVA = "0x169BBE4", Offset = "0x169BBE4", VA = "0x169BBE4", Slot = "6")]
	public override void HandleController()
	{
	}

	[Token(Token = "0x6002A4E")]
	[Address(RVA = "0x169BE98", Offset = "0x169BE98", VA = "0x169BE98", Slot = "5")]
	public override void SetIsHighlighted(bool active)
	{
	}

	[Token(Token = "0x6002A4F")]
	[Address(RVA = "0x169C080", Offset = "0x169C080", VA = "0x169C080", Slot = "8")]
	public override void ResetValues()
	{
	}

	[Token(Token = "0x6002A50")]
	[Address(RVA = "0x169C088", Offset = "0x169C088", VA = "0x169C088", Slot = "7")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6002A51")]
	[Address(RVA = "0x169C090", Offset = "0x169C090", VA = "0x169C090")]
	public SettingsMenuButtonRow()
	{
	}
}
