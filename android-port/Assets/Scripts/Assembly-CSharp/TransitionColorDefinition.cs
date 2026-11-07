using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TransitionColorDefinition : ScriptableObject
{
	public enum AllowedColors
	{
		RED = 0,
		YELLOW = 1,
		BEIGE = 2,
		GREEN = 3,
		GREEN_DARK = 4,
		BLUE = 5,
		ORANGE = 6,
		BLACK = 7,
		WHITE = 8,
		BROWN = 9,
		DARK_BROWN = 10,
		PINK = 11,
		PURPLE = 12,
		LIGHT_PINK = 13,
		YELLOW_LIGHT = 14,
		BLUE_DARK = 15
	}

	public AllowedColors c1;

	public AllowedColors c2;

	public AllowedColors c3;

	public AllowedColors c4;

	public AllowedColors c5;

	public AllowedColors c6;

	public AllowedColors c7;

	public AllowedColors c8;

	public AllowedColors c9;

	public AllowedColors c10;

	public AllowedColors c11;

	public AllowedColors c12;

	public AllowedColors c13;

	public List<Color> colorPreview;

	internal void SetPreviewColors()
	{
	}

	public static Color FromAllowedColor(AllowedColors a)
	{
		return default;
	}

	private static string StringFromAllowedColor(AllowedColors a)
	{
		return null;
	}
}
