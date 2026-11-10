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
		colorPreview = new List<Color>
		{
			FromAllowedColor(c1),
			FromAllowedColor(c2),
			FromAllowedColor(c3),
			FromAllowedColor(c4),
			FromAllowedColor(c5),
			FromAllowedColor(c6),
			FromAllowedColor(c7),
			FromAllowedColor(c8),
			FromAllowedColor(c9),
			FromAllowedColor(c10),
			FromAllowedColor(c11),
			FromAllowedColor(c12),
			FromAllowedColor(c13)
		};
	}

	public static Color FromAllowedColor(AllowedColors a)
	{
		if (ColorUtility.TryParseHtmlString(StringFromAllowedColor(a), out var color))
		{
			return color;
		}
		return Color.white;
	}

	private static string StringFromAllowedColor(AllowedColors a)
	{
		switch (a)
		{
		case AllowedColors.RED:
			return "#B95A62";
		case AllowedColors.YELLOW:
			return "#FAA82A";
		case AllowedColors.BEIGE:
			return "#E8F9C0";
		case AllowedColors.GREEN:
			return "#69B781";
		case AllowedColors.GREEN_DARK:
			return "#19AC82";
		case AllowedColors.BLUE:
			return "#1E98B0";
		case AllowedColors.ORANGE:
			return "#F47D3D";
		case AllowedColors.BLACK:
			return "#000000";
		case AllowedColors.WHITE:
			return "#FFFFFF";
		case AllowedColors.BROWN:
			return "#8B5A2B";
		case AllowedColors.DARK_BROWN:
			return "#584641";
		case AllowedColors.PINK:
			return "#EA6E99";
		case AllowedColors.PURPLE:
			return "#7B52AB";
		case AllowedColors.LIGHT_PINK:
			return "#F5B8C8";
		case AllowedColors.YELLOW_LIGHT:
			return "#EFD466";
		case AllowedColors.BLUE_DARK:
			return "#062844";
		default:
			return "#FFFFFF";
		}
	}
}
