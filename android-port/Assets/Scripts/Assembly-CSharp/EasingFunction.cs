using UnityEngine;

public static class EasingFunction
{
	public enum Ease
	{
		EaseInQuad = 0,
		EaseOutQuad = 1,
		EaseInOutQuad = 2,
		EaseInCubic = 3,
		EaseOutCubic = 4,
		EaseInOutCubic = 5,
		EaseInQuart = 6,
		EaseOutQuart = 7,
		EaseInOutQuart = 8,
		EaseInQuint = 9,
		EaseOutQuint = 10,
		EaseInOutQuint = 11,
		EaseInSine = 12,
		EaseOutSine = 13,
		EaseInOutSine = 14,
		EaseInExpo = 15,
		EaseOutExpo = 16,
		EaseInOutExpo = 17,
		EaseInCirc = 18,
		EaseOutCirc = 19,
		EaseInOutCirc = 20,
		Linear = 21,
		Spring = 22,
		EaseInBounce = 23,
		EaseOutBounce = 24,
		EaseInOutBounce = 25,
		EaseInBack = 26,
		EaseOutBack = 27,
		EaseInOutBack = 28,
		EaseInElastic = 29,
		EaseOutElastic = 30,
		EaseInOutElastic = 31
	}

	public delegate float Function(float s, float e, float v);

	public static float Linear(float start, float end, float value)
	{
		return Mathf.Lerp(start, end, value);
	}

	public static float Spring(float start, float end, float value)
	{
		value = Mathf.Clamp01(value);
		value = (Mathf.Sin(value * Mathf.PI * (0.2f + 2.5f * value * value * value)) * Mathf.Pow(1f - value, 2.2f) + value) * (1f + 1.2f * (1f - value));
		return start + (end - start) * value;
	}

	public static float EaseInQuad(float start, float end, float value)
	{
		end -= start;
		return end * value * value + start;
	}

	public static float EaseOutQuad(float start, float end, float value)
	{
		end -= start;
		return (0f - end) * value * (value - 2f) + start;
	}

	public static float EaseInOutQuad(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end * 0.5f * value * value + start;
		}
		value -= 1f;
		return (0f - end) * 0.5f * (value * (value - 2f) - 1f) + start;
	}

	public static float EaseInCubic(float start, float end, float value)
	{
		end -= start;
		return end * value * value * value + start;
	}

	public static float EaseOutCubic(float start, float end, float value)
	{
		value -= 1f;
		end -= start;
		return end * (value * value * value + 1f) + start;
	}

	public static float EaseInOutCubic(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end * 0.5f * value * value * value + start;
		}
		value -= 2f;
		return end * 0.5f * (value * value * value + 2f) + start;
	}

	public static float EaseInQuart(float start, float end, float value)
	{
		end -= start;
		return end * value * value * value * value + start;
	}

	public static float EaseOutQuart(float start, float end, float value)
	{
		value -= 1f;
		end -= start;
		return (0f - end) * (value * value * value * value - 1f) + start;
	}

	public static float EaseInOutQuart(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end * 0.5f * value * value * value * value + start;
		}
		value -= 2f;
		return (0f - end) * 0.5f * (value * value * value * value - 2f) + start;
	}

	public static float EaseInQuint(float start, float end, float value)
	{
		end -= start;
		return end * value * value * value * value * value + start;
	}

	public static float EaseOutQuint(float start, float end, float value)
	{
		value -= 1f;
		end -= start;
		return end * (value * value * value * value * value + 1f) + start;
	}

	public static float EaseInOutQuint(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end * 0.5f * value * value * value * value * value + start;
		}
		value -= 2f;
		return end * 0.5f * (value * value * value * value * value + 2f) + start;
	}

	public static float EaseInSine(float start, float end, float value)
	{
		end -= start;
		return (0f - end) * Mathf.Cos(value * (Mathf.PI / 2f)) + end + start;
	}

	public static float EaseOutSine(float start, float end, float value)
	{
		end -= start;
		return end * Mathf.Sin(value * (Mathf.PI / 2f)) + start;
	}

	public static float EaseInOutSine(float start, float end, float value)
	{
		end -= start;
		return (0f - end) * 0.5f * (Mathf.Cos(Mathf.PI * value) - 1f) + start;
	}

	public static float EaseInExpo(float start, float end, float value)
	{
		end -= start;
		return end * Mathf.Pow(2f, 10f * (value - 1f)) + start;
	}

	public static float EaseOutExpo(float start, float end, float value)
	{
		end -= start;
		return end * (0f - Mathf.Pow(2f, -10f * value) + 1f) + start;
	}

	public static float EaseInOutExpo(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end * 0.5f * Mathf.Pow(2f, 10f * (value - 1f)) + start;
		}
		value -= 1f;
		return end * 0.5f * (0f - Mathf.Pow(2f, -10f * value) + 2f) + start;
	}

	public static float EaseInCirc(float start, float end, float value)
	{
		end -= start;
		return (0f - end) * (Mathf.Sqrt(1f - value * value) - 1f) + start;
	}

	public static float EaseOutCirc(float start, float end, float value)
	{
		value -= 1f;
		end -= start;
		return end * Mathf.Sqrt(1f - value * value) + start;
	}

	public static float EaseInOutCirc(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return (0f - end) * 0.5f * (Mathf.Sqrt(1f - value * value) - 1f) + start;
		}
		value -= 2f;
		return end * 0.5f * (Mathf.Sqrt(1f - value * value) + 1f) + start;
	}

	public static float EaseInBounce(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		return end - EaseOutBounce(0f, end, num - value) + start;
	}

	public static float EaseOutBounce(float start, float end, float value)
	{
		value /= 1f;
		end -= start;
		if (value < 0.36363637f)
		{
			return end * (7.5625f * value * value) + start;
		}
		if (value < 0.72727275f)
		{
			value -= 0.54545456f;
			return end * (7.5625f * value * value + 0.75f) + start;
		}
		if ((double)value < 0.9090909090909091)
		{
			value -= 0.8181818f;
			return end * (7.5625f * value * value + 0.9375f) + start;
		}
		value -= 21f / 22f;
		return end * (7.5625f * value * value + 63f / 64f) + start;
	}

	public static float EaseInOutBounce(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		if (value < num * 0.5f)
		{
			return EaseInBounce(0f, end, value * 2f) * 0.5f + start;
		}
		return EaseOutBounce(0f, end, value * 2f - num) * 0.5f + end * 0.5f + start;
	}

	public static float EaseInBack(float start, float end, float value)
	{
		end -= start;
		value /= 1f;
		float num = 1.70158f;
		return end * value * value * ((num + 1f) * value - num) + start;
	}

	public static float EaseOutBack(float start, float end, float value)
	{
		float num = 1.70158f;
		end -= start;
		value -= 1f;
		return end * (value * value * ((num + 1f) * value + num) + 1f) + start;
	}

	public static float EaseInOutBack(float start, float end, float value)
	{
		float num = 1.70158f;
		end -= start;
		value /= 0.5f;
		if (value < 1f)
		{
			num *= 1.525f;
			return end * 0.5f * (value * value * ((num + 1f) * value - num)) + start;
		}
		value -= 2f;
		num *= 1.525f;
		return end * 0.5f * (value * value * ((num + 1f) * value + num) + 2f) + start;
	}

	public static float EaseInElastic(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		float num4 = 0f;
		if (value == 0f)
		{
			return start;
		}
		if ((value /= num) == 1f)
		{
			return start + end;
		}
		if (num4 == 0f || num4 < Mathf.Abs(end))
		{
			num4 = end;
			num3 = num2 / 4f;
		}
		else
		{
			num3 = num2 / (Mathf.PI * 2f) * Mathf.Asin(end / num4);
		}
		return 0f - num4 * Mathf.Pow(2f, 10f * (value -= 1f)) * Mathf.Sin((value * num - num3) * (Mathf.PI * 2f) / num2) + start;
	}

	public static float EaseOutElastic(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		float num4 = 0f;
		if (value == 0f)
		{
			return start;
		}
		if ((value /= num) == 1f)
		{
			return start + end;
		}
		if (num4 == 0f || num4 < Mathf.Abs(end))
		{
			num4 = end;
			num3 = num2 * 0.25f;
		}
		else
		{
			num3 = num2 / (Mathf.PI * 2f) * Mathf.Asin(end / num4);
		}
		return num4 * Mathf.Pow(2f, -10f * value) * Mathf.Sin((value * num - num3) * (Mathf.PI * 2f) / num2) + end + start;
	}

	public static float EaseInOutElastic(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		float num4 = 0f;
		if (value == 0f)
		{
			return start;
		}
		if ((value /= num * 0.5f) == 2f)
		{
			return start + end;
		}
		if (num4 == 0f || num4 < Mathf.Abs(end))
		{
			num4 = end;
			num3 = num2 / 4f;
		}
		else
		{
			num3 = num2 / (Mathf.PI * 2f) * Mathf.Asin(end / num4);
		}
		if (value < 1f)
		{
			return -0.5f * (num4 * Mathf.Pow(2f, 10f * (value -= 1f)) * Mathf.Sin((value * num - num3) * (Mathf.PI * 2f) / num2)) + start;
		}
		return num4 * Mathf.Pow(2f, -10f * (value -= 1f)) * Mathf.Sin((value * num - num3) * (Mathf.PI * 2f) / num2) * 0.5f + end + start;
	}

	public static Function GetEasingFunction(Ease easingFunction)
	{
		return easingFunction switch
		{
			Ease.EaseInQuad => EaseInQuad,
			Ease.EaseOutQuad => EaseOutQuad,
			Ease.EaseInOutQuad => EaseInOutQuad,
			Ease.EaseInCubic => EaseInCubic,
			Ease.EaseOutCubic => EaseOutCubic,
			Ease.EaseInOutCubic => EaseInOutCubic,
			Ease.EaseInQuart => EaseInQuart,
			Ease.EaseOutQuart => EaseOutQuart,
			Ease.EaseInOutQuart => EaseInOutQuart,
			Ease.EaseInQuint => EaseInQuint,
			Ease.EaseOutQuint => EaseOutQuint,
			Ease.EaseInOutQuint => EaseInOutQuint,
			Ease.EaseInSine => EaseInSine,
			Ease.EaseOutSine => EaseOutSine,
			Ease.EaseInOutSine => EaseInOutSine,
			Ease.EaseInExpo => EaseInExpo,
			Ease.EaseOutExpo => EaseOutExpo,
			Ease.EaseInOutExpo => EaseInOutExpo,
			Ease.EaseInCirc => EaseInCirc,
			Ease.EaseOutCirc => EaseOutCirc,
			Ease.EaseInOutCirc => EaseInOutCirc,
			Ease.Linear => Linear,
			Ease.Spring => Spring,
			Ease.EaseInBounce => EaseInBounce,
			Ease.EaseOutBounce => EaseOutBounce,
			Ease.EaseInOutBounce => EaseInOutBounce,
			Ease.EaseInBack => EaseInBack,
			Ease.EaseOutBack => EaseOutBack,
			Ease.EaseInOutBack => EaseInOutBack,
			Ease.EaseInElastic => EaseInElastic,
			Ease.EaseOutElastic => EaseOutElastic,
			Ease.EaseInOutElastic => EaseInOutElastic,
			_ => Linear,
		};
	}
}
