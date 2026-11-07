using System;
using System.Collections;

public static class pTween
{
	public enum TimeMode
	{
		Normal = 0,
		Unscaled = 1,
		Realtime = 2
	}

	private static float GetCurrentTime(TimeMode mode)
	{
		return 0f;
	}

	public static IEnumerator To(float duration, float startValue, float endValue, Action<float> callback, TimeMode timeMode = TimeMode.Normal, bool useFixedUpdate = false)
	{
		return null;
	}

	public static IEnumerator To(float duration, Action<float> callback, bool useFixedUpdate = false)
	{
		return null;
	}

	public static IEnumerator ToRealTime(float duration, Action<float> callback)
	{
		return null;
	}

	public static IEnumerator Then(this IEnumerator coroutine, IEnumerator after)
	{
		return null;
	}

	public static IEnumerator Then(this IEnumerator coroutine, Action after)
	{
		return null;
	}

	public static IEnumerator Then(this IEnumerator coroutine, float delay, Action after)
	{
		return null;
	}
}
