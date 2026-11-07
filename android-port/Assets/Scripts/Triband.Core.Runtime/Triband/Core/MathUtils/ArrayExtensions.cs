using UnityEngine;

namespace Triband.Core.MathUtils
{
	public static class ArrayExtensions
	{
		public static float Sample(this float[] arr, float t)
		{
			if (arr == null || arr.Length == 0) return 0f;
			if (arr.Length == 1) return arr[0];
			float f = Mathf.Clamp01(t) * (arr.Length - 1);
			int i0 = Mathf.FloorToInt(f);
			int i1 = Mathf.Min(i0 + 1, arr.Length - 1);
			return Mathf.Lerp(arr[i0], arr[i1], f - i0);
		}

		public static float InverseSample(this float[] arr, float value)
		{
			if (arr == null || arr.Length <= 1) return 0f;
			if (value <= arr[0]) return 0f;
			int last = arr.Length - 1;
			if (value >= arr[last]) return 1f;
			for (int i = 0; i < last; i++)
			{
				if (value >= arr[i] && value <= arr[i + 1])
				{
					float span = arr[i + 1] - arr[i];
					float localT = span > 1e-6f ? (value - arr[i]) / span : 0f;
					return (i + localT) / last;
				}
			}
			return 1f;
		}
	}
}
