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
		return 0f;
	}

	public static float Spring(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInQuad(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseOutQuad(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInOutQuad(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInCubic(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseOutCubic(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInOutCubic(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInQuart(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseOutQuart(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInOutQuart(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInQuint(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseOutQuint(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInOutQuint(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInSine(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseOutSine(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInOutSine(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInExpo(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseOutExpo(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInOutExpo(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInCirc(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseOutCirc(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInOutCirc(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInBounce(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseOutBounce(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInOutBounce(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInBack(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseOutBack(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInOutBack(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInElastic(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseOutElastic(float start, float end, float value)
	{
		return 0f;
	}

	public static float EaseInOutElastic(float start, float end, float value)
	{
		return 0f;
	}

	public static Function GetEasingFunction(Ease easingFunction)
	{
		return null;
	}
}
