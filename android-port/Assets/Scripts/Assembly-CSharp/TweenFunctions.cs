using UnityEngine;

public static class TweenFunctions
{
	public static float Linear(float t) => t;
	public static float EaseOut(float t) => Mathf.Sin(t * Mathf.PI * 0.5f);
	public static float EaseIn(float t) => 1f - Mathf.Cos(t * Mathf.PI * 0.5f);
	public static float EaseInOut(float t) => SmoothStep(t);
	public static float Exponential(float t) => t * t;
	public static float SmoothStep(float t) => t * t * (3f - 2f * t);
	public static float SmootherStep(float t) => t * t * t * (t * (t * 6f - 15f) + 10f);

	public static Vector3 Bezier(Vector3 start, Vector3 control, Vector3 end, float t)
	{
		if (t < 0f) t = 0f;
		else if (t > 1f) t = 1f;
		float u = 1f - t;
		return u * u * start + 2f * u * t * control + t * t * end;
	}

	public static float punch(float amplitude, float value)
	{
		if (value == 0f || value == 1f) return 0f;
		return amplitude * Mathf.Pow(2f, -10f * value) * Mathf.Sin((value - 0.075f) * (2f * Mathf.PI) / 0.3f);
	}

	public static float ElasticOut(float k)
	{
		if (k == 0f) return 0f;
		if (k == 1f) return 1f;
		return Mathf.Pow(2f, -10f * k) * Mathf.Sin((k - 0.1f) * (5f * Mathf.PI)) + 1f;
	}

	public static float ElasticInOut(float k)
	{
		if (k == 0f) return 0f;
		if ((k *= 2f) == 2f) return 1f;
		if (k < 1f)
			return -0.5f * (Mathf.Pow(2f, 10f * (k -= 1f)) * Mathf.Sin((k - 0.1f) * (5f * Mathf.PI)));
		return Mathf.Pow(2f, -10f * (k -= 1f)) * Mathf.Sin((k - 0.1f) * (5f * Mathf.PI)) * 0.5f + 1f;
	}

	public static float EaseOutBounce(float start, float end, float value)
	{
		value /= 1f;
		end -= start;
		if (value < 1f / 2.75f)
			return end * (7.5625f * value * value) + start;
		if (value < 2f / 2.75f)
		{
			value -= 1.5f / 2.75f;
			return end * (7.5625f * value * value + 0.75f) + start;
		}
		if (value < 2.5f / 2.75f)
		{
			value -= 2.25f / 2.75f;
			return end * (7.5625f * value * value + 0.9375f) + start;
		}
		value -= 2.625f / 2.75f;
		return end * (7.5625f * value * value + 0.984375f) + start;
	}
}
