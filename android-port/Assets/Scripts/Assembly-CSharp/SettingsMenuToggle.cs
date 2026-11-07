using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000929")]
public class SettingsMenuToggle : SettingsMenuCommon
{
	[Token(Token = "0x40031FB")]
	[FieldOffset(Offset = "0x40")]
	public Animator toggleAnim;

	[Token(Token = "0x40031FC")]
	[FieldOffset(Offset = "0x48")]
	public GameObject On;

	[Token(Token = "0x40031FD")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Off;

	[Token(Token = "0x40031FE")]
	[FieldOffset(Offset = "0x58")]
	public ScrollableButton button;

	[Token(Token = "0x40031FF")]
	[FieldOffset(Offset = "0x60")]
	private Func<bool> DefaultValue;

	[Token(Token = "0x6002A74")]
	[Address(RVA = "0x169984C", Offset = "0x169984C", VA = "0x169984C")]
	public void SetToggle(bool on)
	{
	}

	[Token(Token = "0x6002A75")]
	[Address(RVA = "0x169742C", Offset = "0x169742C", VA = "0x169742C")]
	public void Init(Func<bool> defaultValue, UnityAction onChange, bool active, SettingsMenu settings)
	{
	}

	[Token(Token = "0x6002A76")]
	[Address(RVA = "0x169CB84", Offset = "0x169CB84", VA = "0x169CB84", Slot = "6")]
	public override void HandleController()
	{
	}

	[Token(Token = "0x6002A77")]
	[Address(RVA = "0x169CC6C", Offset = "0x169CC6C", VA = "0x169CC6C", Slot = "8")]
	public override void ResetValues()
	{
	}

	[Token(Token = "0x6002A78")]
	[Address(RVA = "0x169CCEC", Offset = "0x169CCEC", VA = "0x169CCEC", Slot = "7")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6002A79")]
	[Address(RVA = "0x169CD6C", Offset = "0x169CD6C", VA = "0x169CD6C")]
	public SettingsMenuToggle()
	{
	}
}
