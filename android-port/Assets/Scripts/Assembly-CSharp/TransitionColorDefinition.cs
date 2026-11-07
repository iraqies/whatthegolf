using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000EB6")]
public class TransitionColorDefinition : ScriptableObject
{
	[Token(Token = "0x2000EB7")]
	public enum AllowedColors
	{
		[Token(Token = "0x4004F83")]
		RED = 0,
		[Token(Token = "0x4004F84")]
		YELLOW = 1,
		[Token(Token = "0x4004F85")]
		BEIGE = 2,
		[Token(Token = "0x4004F86")]
		GREEN = 3,
		[Token(Token = "0x4004F87")]
		GREEN_DARK = 4,
		[Token(Token = "0x4004F88")]
		BLUE = 5,
		[Token(Token = "0x4004F89")]
		ORANGE = 6,
		[Token(Token = "0x4004F8A")]
		BLACK = 7,
		[Token(Token = "0x4004F8B")]
		WHITE = 8,
		[Token(Token = "0x4004F8C")]
		BROWN = 9,
		[Token(Token = "0x4004F8D")]
		DARK_BROWN = 10,
		[Token(Token = "0x4004F8E")]
		PINK = 11,
		[Token(Token = "0x4004F8F")]
		PURPLE = 12,
		[Token(Token = "0x4004F90")]
		LIGHT_PINK = 13,
		[Token(Token = "0x4004F91")]
		YELLOW_LIGHT = 14,
		[Token(Token = "0x4004F92")]
		BLUE_DARK = 15
	}

	[Token(Token = "0x4004F74")]
	[FieldOffset(Offset = "0x18")]
	public AllowedColors c1;

	[Token(Token = "0x4004F75")]
	[FieldOffset(Offset = "0x1C")]
	public AllowedColors c2;

	[Token(Token = "0x4004F76")]
	[FieldOffset(Offset = "0x20")]
	public AllowedColors c3;

	[Token(Token = "0x4004F77")]
	[FieldOffset(Offset = "0x24")]
	public AllowedColors c4;

	[Token(Token = "0x4004F78")]
	[FieldOffset(Offset = "0x28")]
	public AllowedColors c5;

	[Token(Token = "0x4004F79")]
	[FieldOffset(Offset = "0x2C")]
	public AllowedColors c6;

	[Token(Token = "0x4004F7A")]
	[FieldOffset(Offset = "0x30")]
	public AllowedColors c7;

	[Token(Token = "0x4004F7B")]
	[FieldOffset(Offset = "0x34")]
	public AllowedColors c8;

	[Token(Token = "0x4004F7C")]
	[FieldOffset(Offset = "0x38")]
	public AllowedColors c9;

	[Token(Token = "0x4004F7D")]
	[FieldOffset(Offset = "0x3C")]
	public AllowedColors c10;

	[Token(Token = "0x4004F7E")]
	[FieldOffset(Offset = "0x40")]
	public AllowedColors c11;

	[Token(Token = "0x4004F7F")]
	[FieldOffset(Offset = "0x44")]
	public AllowedColors c12;

	[Token(Token = "0x4004F80")]
	[FieldOffset(Offset = "0x48")]
	public AllowedColors c13;

	[Token(Token = "0x4004F81")]
	[FieldOffset(Offset = "0x50")]
	public List<Color> colorPreview;

	[Token(Token = "0x60044AE")]
	[Address(RVA = "0x172BCB8", Offset = "0x172BCB8", VA = "0x172BCB8")]
	internal void SetPreviewColors()
	{
	}

	[Token(Token = "0x60044AF")]
	[Address(RVA = "0x172C060", Offset = "0x172C060", VA = "0x172C060")]
	public static Color FromAllowedColor(AllowedColors a)
	{
		return default;
	}

	[Token(Token = "0x60044B0")]
	[Address(RVA = "0x172C0A4", Offset = "0x172C0A4", VA = "0x172C0A4")]
	private static string StringFromAllowedColor(AllowedColors a)
	{
		return null;
	}

	[Token(Token = "0x60044B1")]
	[Address(RVA = "0x172C1D4", Offset = "0x172C1D4", VA = "0x172C1D4")]
	public TransitionColorDefinition()
	{
	}
}
