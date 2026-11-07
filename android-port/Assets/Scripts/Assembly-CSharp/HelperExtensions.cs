using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public static class HelperExtensions
{
	public static T Ref<T>(this T obj) where T : UnityEngine.Object
	{
		return null;
	}

	public static void SafeDestroy(this UnityEngine.Object obj)
	{
	}

	public static void SafeDestroyGameObject(this Component obj)
	{
	}

	public static T GetArg<T>(this object[] array, int index, T defaultValue = default(T))
	{
		return default;
	}

	public static Task<bool> WaitUntilAsync(this MonoBehaviour obj, Func<bool> predicate)
	{
		return null;
	}

	public static Task<bool> WaitAsync(this MonoBehaviour obj, IEnumerator coroutine)
	{
		return null;
	}

	public static IEnumerator YieldTask(this Task t)
	{
		return null;
	}

	private static IEnumerator WaitForCoroutine(TaskCompletionSource<bool> tcs, IEnumerator cr)
	{
		return null;
	}

	private static IEnumerator WaitUntil(TaskCompletionSource<bool> tcs, Func<bool> predicate)
	{
		return null;
	}
}
