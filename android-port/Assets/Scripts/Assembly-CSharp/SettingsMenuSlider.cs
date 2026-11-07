using System;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.UI;

[Token(Token = "0x2000928")]
public class SettingsMenuSlider : SettingsMenuCommon
{
	[Token(Token = "0x40031F7")]
	[FieldOffset(Offset = "0x40")]
	public Slider slider;

	[Token(Token = "0x40031F8")]
	[FieldOffset(Offset = "0x48")]
	private Func<float> DefaultValue;

	[Token(Token = "0x40031F9")]
	[FieldOffset(Offset = "0x50")]
	private UnityAction<float> OnChange;

	[Token(Token = "0x40031FA")]
	[FieldOffset(Offset = "0x58")]
	private bool waitForInputReset;

	[Token(Token = "0x6002A6F")]
	[Address(RVA = "0x1697234", Offset = "0x1697234", VA = "0x1697234")]
	public void Init(Func<float> defaultValue, UnityAction<float> onChange, bool active, SettingsMenu settings)
	{
	}

	[Token(Token = "0x6002A70")]
	[Address(RVA = "0x169C95C", Offset = "0x169C95C", VA = "0x169C95C", Slot = "6")]
	public override void HandleController()
	{
	}

	[Token(Token = "0x6002A71")]
	[Address(RVA = "0x169CA5C", Offset = "0x169CA5C", VA = "0x169CA5C", Slot = "8")]
	public override void ResetValues()
	{
	}

	[Token(Token = "0x6002A72")]
	[Address(RVA = "0x169CB10", Offset = "0x169CB10", VA = "0x169CB10", Slot = "7")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6002A73")]
	[Address(RVA = "0x169CB7C", Offset = "0x169CB7C", VA = "0x169CB7C")]
	public SettingsMenuSlider()
	{
	}
}
