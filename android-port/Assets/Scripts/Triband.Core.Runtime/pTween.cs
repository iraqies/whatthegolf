using System;
using System.Collections;
using UnityEngine;

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
		switch (mode)
		{
			case TimeMode.Unscaled: return Time.unscaledTime;
			case TimeMode.Realtime: return Time.realtimeSinceStartup;
			default: return Time.time;
		}
	}

	public static IEnumerator To(float duration, float startValue, float endValue, Action<float> callback, TimeMode timeMode = TimeMode.Normal, bool useFixedUpdate = false)
	{
		if (duration <= 0f)
		{
			callback?.Invoke(endValue);
			yield break;
		}
		float start = GetCurrentTime(timeMode);
		float end = start + duration;
		WaitForFixedUpdate waitFixed = useFixedUpdate ? new WaitForFixedUpdate() : null;
		while (true)
		{
			float now = GetCurrentTime(timeMode);
			if (now >= end) break;
			float t = Mathf.Clamp01((now - start) / duration);
			callback?.Invoke(Mathf.Lerp(startValue, endValue, t));
			yield return waitFixed;
		}
		callback?.Invoke(endValue);
	}

	public static IEnumerator To(float duration, Action<float> callback, bool useFixedUpdate = false)
	{
		return To(duration, 0f, 1f, callback, TimeMode.Normal, useFixedUpdate);
	}

	public static IEnumerator ToRealTime(float duration, Action<float> callback)
	{
		return To(duration, 0f, 1f, callback, TimeMode.Realtime, false);
	}

	public static IEnumerator Then(this IEnumerator coroutine, IEnumerator after)
	{
		if (coroutine != null)
		{
			while (coroutine.MoveNext())
				yield return coroutine.Current;
		}
		if (after != null)
		{
			while (after.MoveNext())
				yield return after.Current;
		}
	}

	public static IEnumerator Then(this IEnumerator coroutine, Action after)
	{
		if (coroutine != null)
		{
			while (coroutine.MoveNext())
				yield return coroutine.Current;
		}
		after?.Invoke();
	}

	public static IEnumerator Then(this IEnumerator coroutine, float delay, Action after)
	{
		if (coroutine != null)
		{
			while (coroutine.MoveNext())
				yield return coroutine.Current;
		}
		if (delay > 0f)
			yield return new WaitForSeconds(delay);
		after?.Invoke();
	}
}
