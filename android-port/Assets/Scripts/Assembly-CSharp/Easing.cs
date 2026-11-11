using System;
using UnityEngine;

public class Easing
{
	public class Quadratic
	{
		public static float In(float k) => k * k;
	}

	public class Cubic
	{
		public static float Out(float k) => 1f + (k -= 1f) * k * k;
	}

	public class Quartic
	{
		public static float In(float k) => k * k * k * k;
	}

	public class Back
	{
		private static float s = 1.70158f;

		private static float s2 = 2.5949094f;

		public static float InOut(float k)
		{
			if ((k *= 2f) < 1f)
			{
				return 0.5f * (k * k * ((s2 + 1f) * k - s2));
			}
			return 0.5f * ((k -= 2f) * k * ((s2 + 1f) * k + s2) + 2f);
		}
	}

	public class Bounce
	{
		public static float Out(float k) => Easing.BounceOut(k);
	}

	public enum EasingType
	{
		Linear = 0,
		QuadraticIn = 1,
		QuadraticOut = 2,
		QuadraticInOut = 3,
		CubicIn = 4,
		CubicOut = 5,
		CubicInOut = 6,
		QuarticIn = 7,
		QuarticOut = 8,
		QuarticInOut = 9,
		QuinticIn = 10,
		QuinticOut = 11,
		QuinticInOut = 12,
		SinusoidalIn = 13,
		SinusoidalOut = 14,
		SinusoidalInOut = 15,
		ExponentialIn = 16,
		ExponentialOut = 17,
		ExponentialInOut = 18,
		CircularIn = 19,
		CircularOut = 20,
		CircularInOut = 21,
		ElasticIn = 22,
		ElasticOut = 23,
		ElasticInOut = 24,
		BackIn = 25,
		BackOut = 26,
		BackInOut = 27,
		BounceIn = 28,
		BounceOut = 29,
		BounceInOut = 30
	}

	public static float Ease(float t, EasingType type)
	{
		switch (type)
		{
		case EasingType.Linear:
			return Linear(t);
		case EasingType.QuadraticIn:
			return QuadraticIn(t);
		case EasingType.QuadraticOut:
			return QuadraticOut(t);
		case EasingType.QuadraticInOut:
			return QuadraticInOut(t);
		case EasingType.CubicIn:
			return CubicIn(t);
		case EasingType.CubicOut:
			return CubicOut(t);
		case EasingType.CubicInOut:
			return CubicInOut(t);
		case EasingType.QuarticIn:
			return QuarticIn(t);
		case EasingType.QuarticOut:
			return QuarticOut(t);
		case EasingType.QuarticInOut:
			return QuarticInOut(t);
		case EasingType.QuinticIn:
			return QuinticIn(t);
		case EasingType.QuinticOut:
			return QuinticOut(t);
		case EasingType.QuinticInOut:
			return QuinticInOut(t);
		case EasingType.SinusoidalIn:
			return SinusoidalIn(t);
		case EasingType.SinusoidalOut:
			return SinusoidalOut(t);
		case EasingType.SinusoidalInOut:
			return SinusoidalInOut(t);
		case EasingType.ExponentialIn:
			return ExponentialIn(t);
		case EasingType.ExponentialOut:
			return ExponentialOut(t);
		case EasingType.ExponentialInOut:
			return ExponentialInOut(t);
		case EasingType.CircularIn:
			return CircularIn(t);
		case EasingType.CircularOut:
			return CircularOut(t);
		case EasingType.CircularInOut:
			return CircularInOut(t);
		case EasingType.ElasticIn:
			return ElasticIn(t);
		case EasingType.ElasticOut:
			return ElasticOut(t);
		case EasingType.ElasticInOut:
			return ElasticInOut(t);
		case EasingType.BackIn:
			return BackIn(t);
		case EasingType.BackOut:
			return BackOut(t);
		case EasingType.BackInOut:
			return BackInOut(t);
		case EasingType.BounceIn:
			return BounceIn(t);
		case EasingType.BounceOut:
			return BounceOut(t);
		case EasingType.BounceInOut:
			return BounceInOut(t);
		default:
			throw new ArgumentOutOfRangeException(nameof(type), type, null);
		}
	}

	public static float Linear(float k) => k;

	public static float QuadraticIn(float k) => k * k;

	public static float QuadraticOut(float k) => k * (2f - k);

	public static float QuadraticInOut(float k) => (k *= 2f) < 1f ? 0.5f * k * k : -0.5f * ((k -= 1f) * (k - 2f) - 1f);

	public static float CubicIn(float k) => k * k * k;

	public static float CubicOut(float k) => 1f + (k -= 1f) * k * k;

	public static float CubicInOut(float k) => (k *= 2f) < 1f ? 0.5f * k * k * k : 0.5f * ((k -= 2f) * k * k + 2f);

	public static float QuarticIn(float k) => k * k * k * k;

	public static float QuarticOut(float k) => 1f - (k -= 1f) * k * k * k;

	public static float QuarticInOut(float k) => (k *= 2f) < 1f ? 0.5f * k * k * k * k : -0.5f * ((k -= 2f) * k * k * k - 2f);

	public static float QuinticIn(float k) => k * k * k * k * k;

	public static float QuinticOut(float k) => 1f + (k -= 1f) * k * k * k * k;

	public static float QuinticInOut(float k) => (k *= 2f) < 1f ? 0.5f * k * k * k * k * k : 0.5f * ((k -= 2f) * k * k * k * k + 2f);

	public static float SinusoidalIn(float k) => 1f - Mathf.Cos(k * (Mathf.PI / 2f));

	public static float SinusoidalOut(float k) => Mathf.Sin(k * (Mathf.PI / 2f));

	public static float SinusoidalInOut(float k) => 0.5f * (1f - Mathf.Cos(Mathf.PI * k));

	public static float ExponentialIn(float k) => k == 0f ? 0f : Mathf.Pow(1024f, k - 1f);

	public static float ExponentialOut(float k) => k == 1f ? 1f : 1f - Mathf.Pow(2f, -10f * k);

	public static float ExponentialInOut(float k)
	{
		if (k == 0f) return 0f;
		if (k == 1f) return 1f;
		return (k *= 2f) < 1f ? 0.5f * Mathf.Pow(1024f, k - 1f) : 0.5f * (-Mathf.Pow(2f, -10f * (k - 1f)) + 2f);
	}

	public static float CircularIn(float k) => 1f - Mathf.Sqrt(1f - k * k);

	public static float CircularOut(float k) => Mathf.Sqrt(1f - (k -= 1f) * k);

	public static float CircularInOut(float k) => (k *= 2f) < 1f ? -0.5f * (Mathf.Sqrt(1f - k * k) - 1f) : 0.5f * (Mathf.Sqrt(1f - (k -= 2f) * k) + 1f);

	public static float ElasticIn(float k)
	{
		if (k == 0f) return 0f;
		if (k == 1f) return 1f;
		return -Mathf.Pow(2f, 10f * (k -= 1f)) * Mathf.Sin((k - 0.1f) * (Mathf.PI * 2f) / 0.4f);
	}

	public static float ElasticOut(float k)
	{
		if (k == 0f) return 0f;
		if (k == 1f) return 1f;
		return Mathf.Pow(2f, -10f * k) * Mathf.Sin((k - 0.1f) * (Mathf.PI * 2f) / 0.4f) + 1f;
	}

	public static float ElasticInOut(float k)
	{
		if ((k *= 2f) < 1f)
		{
			return -0.5f * Mathf.Pow(2f, 10f * (k -= 1f)) * Mathf.Sin((k - 0.1f) * (Mathf.PI * 2f) / 0.4f);
		}
		return Mathf.Pow(2f, -10f * (k -= 1f)) * Mathf.Sin((k - 0.1f) * (Mathf.PI * 2f) / 0.4f) * 0.5f + 1f;
	}

	public static float BackIn(float k) => k * k * (2.70158f * k - 1.70158f);

	public static float BackOut(float k) => (k -= 1f) * k * (2.70158f * k + 1.70158f) + 1f;

	public static float BackInOut(float k)
	{
		const float s = 2.5949094f;
		return (k *= 2f) < 1f ? 0.5f * (k * k * ((s + 1f) * k - s)) : 0.5f * ((k -= 2f) * k * ((s + 1f) * k + s) + 2f);
	}

	public static float BounceIn(float k) => 1f - BounceOut(1f - k);

	public static float BounceOut(float k)
	{
		if (k < 1f / 2.75f)
		{
			return 7.5625f * k * k;
		}
		if (k < 2f / 2.75f)
		{
			return 7.5625f * (k -= 1.5f / 2.75f) * k + 0.75f;
		}
		if (k < 2.5f / 2.75f)
		{
			return 7.5625f * (k -= 2.25f / 2.75f) * k + 0.9375f;
		}
		return 7.5625f * (k -= 2.625f / 2.75f) * k + 0.984375f;
	}

	public static float BounceInOut(float k) => k < 0.5f ? BounceIn(k * 2f) * 0.5f : BounceOut(k * 2f - 1f) * 0.5f + 0.5f;
}
