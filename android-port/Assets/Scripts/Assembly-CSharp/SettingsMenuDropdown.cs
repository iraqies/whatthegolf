using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine.Events;

[Token(Token = "0x2000927")]
public class SettingsMenuDropdown : SettingsMenuCommon
{
	[Token(Token = "0x40031F1")]
	[FieldOffset(Offset = "0x40")]
	public TMP_Dropdown DropDown;

	[Token(Token = "0x40031F2")]
	[FieldOffset(Offset = "0x48")]
	private Func<List<string>> Options;

	[Token(Token = "0x40031F3")]
	[FieldOffset(Offset = "0x50")]
	private Func<int> DefaultValue;

	[Token(Token = "0x40031F4")]
	[FieldOffset(Offset = "0x58")]
	private UnityAction<int> OnChange;

	[Token(Token = "0x40031F5")]
	[FieldOffset(Offset = "0x60")]
	private bool selectedLineLockedIn;

	[Token(Token = "0x40031F6")]
	[FieldOffset(Offset = "0x64")]
	private float escapeDelay;

	[Token(Token = "0x6002A6A")]
	[Address(RVA = "0x169732C", Offset = "0x169732C", VA = "0x169732C")]
	public void Init(Func<List<string>> options, Func<int> defaultValue, UnityAction<int> onChange, bool active, SettingsMenu settings)
	{
	}

	[Token(Token = "0x6002A6B")]
	[Address(RVA = "0x169C230", Offset = "0x169C230", VA = "0x169C230", Slot = "6")]
	public override void HandleController()
	{
	}

	[Token(Token = "0x6002A6C")]
	[Address(RVA = "0x169C7E8", Offset = "0x169C7E8", VA = "0x169C7E8", Slot = "8")]
	public override void ResetValues()
	{
	}

	[Token(Token = "0x6002A6D")]
	[Address(RVA = "0x169C8E8", Offset = "0x169C8E8", VA = "0x169C8E8", Slot = "7")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6002A6E")]
	[Address(RVA = "0x169C954", Offset = "0x169C954", VA = "0x169C954")]
	public SettingsMenuDropdown()
	{
	}
}
