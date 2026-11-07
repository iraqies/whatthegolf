using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004E7")]
public class LocalizationFont
{
	[Token(Token = "0x400199C")]
	[FieldOffset(Offset = "0x10")]
	public LocalizationFontStyle Style;

	[Token(Token = "0x400199D")]
	[FieldOffset(Offset = "0x18")]
	public TMP_FontAsset Font;

	[Token(Token = "0x400199E")]
	[FieldOffset(Offset = "0x20")]
	public Material Material;

	[Token(Token = "0x400199F")]
	[FieldOffset(Offset = "0x28")]
	public Material MaterialUGUI;

	[Token(Token = "0x60016A1")]
	[Address(RVA = "0x153D75C", Offset = "0x153D75C", VA = "0x153D75C")]
	public LocalizationFont()
	{
	}
}
