using System;
using System.Collections.Generic;
using UnityEngine;

public static class ScreenResolutions
{
	private static Resolution WindowSize()
	{
		return default;
	}

	public static List<string> SupportedResolutionsAsString()
	{
		return null;
	}

	public static IEnumerable<Resolution> SupportedResolutions()
	{
		return null;
	}

	public static Tuple<int, Resolution> ClosestMathcingResolution(FullScreenMode mode)
	{
		return null;
	}

	public static Tuple<int, Resolution> ClosestMathcingResolution()
	{
		return null;
	}

	public static void ChangeScreenMode(FullScreenMode newScreenMode)
	{
	}

	public static Resolution SelectedResolutionToActualResolution(Resolution r)
	{
		return default;
	}

	private static Resolution SelectedResolutionToActualResolution(Resolution r, FullScreenMode mode)
	{
		return default;
	}
}
