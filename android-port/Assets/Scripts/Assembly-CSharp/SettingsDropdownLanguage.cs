using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000905")]
public class SettingsDropdownLanguage : MonoBehaviour
{
	[Token(Token = "0x400311C")]
	[FieldOffset(Offset = "0x18")]
	public LocalizationFontStyle style;

	[Token(Token = "0x400311D")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI TopLabel;

	[Token(Token = "0x400311E")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI TemplateLabel;

	[Token(Token = "0x60029A4")]
	[Address(RVA = "0x1693840", Offset = "0x1693840", VA = "0x1693840")]
	private void FontCheck()
	{
	}

	[Token(Token = "0x60029A5")]
	[Address(RVA = "0x16939F0", Offset = "0x16939F0", VA = "0x16939F0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60029A6")]
	[Address(RVA = "0x1693AF0", Offset = "0x1693AF0", VA = "0x1693AF0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60029A7")]
	[Address(RVA = "0x1693BE8", Offset = "0x1693BE8", VA = "0x1693BE8")]
	public SettingsDropdownLanguage()
	{
	}
}
