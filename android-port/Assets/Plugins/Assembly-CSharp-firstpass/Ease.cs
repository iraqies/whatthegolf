using UnityEngine;

public static class Ease
{
	public enum Easing
	{
		Linear = 0,
		InQuad = 1,
		OutQuad = 2,
		InOutQuad = 3,
		OutInQuad = 4,
		InCubic = 5,
		OutCubic = 6,
		InOutCubic = 7,
		OutInCubic = 8,
		InQuart = 9,
		OutQuart = 10,
		InOutQuart = 11,
		OutInQuart = 12,
		InQuint = 13,
		OutQuint = 14,
		InOutQuint = 15,
		OutInQuint = 16,
		InSin = 17,
		OutSin = 18,
		InOutSin = 19,
		OutInSin = 20,
		InExp = 21,
		OutExp = 22,
		InOutExp = 23,
		OutInExp = 24,
		InCirc = 25,
		OutCirc = 26,
		InOutCirc = 27,
		OutInCirc = 28,
		InElastic = 29,
		OutElastic = 30,
		InOutElastic = 31,
		OutInElastic = 32,
		InBounce = 33,
		OutBounce = 34,
		InOutBounce = 35,
		OutInBounce = 36,
		InBack = 37,
		OutBack = 38,
		InOutBack = 39,
		OutInBack = 40
	}

	public static float EaseByType(Easing e, float start, float end, float t)
	{
		switch (e)
		{
			case Easing.InQuad: return InQuad(start, end, t);
			case Easing.OutQuad: return OutQuad(start, end, t);
			case Easing.InOutQuad: return InOutQuad(start, end, t);
			case Easing.InCubic: return InCubic(start, end, t);
			case Easing.OutCubic: return OutCubic(start, end, t);
			case Easing.InOutCubic: return InOutCubic(start, end, t);
			case Easing.InQuart: return InQuart(start, end, t);
			case Easing.OutQuart: return OutQuart(start, end, t);
			case Easing.InOutQuart: return InOutQuart(start, end, t);
			case Easing.InQuint: return InQuint(start, end, t);
			case Easing.OutQuint: return OutQuint(start, end, t);
			case Easing.InOutQuint: return InOutQuint(start, end, t);
			case Easing.InSin: return InSin(start, end, t);
			case Easing.OutSin: return OutSin(start, end, t);
			case Easing.InOutSin: return InOutSin(start, end, t);
			case Easing.InExp: return InExp(start, end, t);
			case Easing.OutExp: return OutExp(start, end, t);
			case Easing.InOutExp: return InOutExp(start, end, t);
			case Easing.InCirc: return InCirc(start, end, t);
			case Easing.OutCirc: return OutCirc(start, end, t);
			case Easing.InOutCirc: return InOutCirc(start, end, t);
			case Easing.InBack: return InBack(start, end, t);
			case Easing.OutBack: return OutBack(start, end, t);
			case Easing.InOutBack: return InOutBack(start, end, t);
			case Easing.InBounce: return InBounce(start, end, t);
			case Easing.OutBounce: return OutBounce(start, end, t);
			case Easing.InOutBounce: return InOutBounce(start, end, t);
			default: return Linear(start, end, t);
		}
	}

	public static float Linear(float start, float end, float t) => Mathf.Lerp(start, end, t);
	public static float InQuad(float start, float end, float t) => Mathf.Lerp(start, end, t * t);
	public static float OutQuad(float start, float end, float t) => Mathf.Lerp(start, end, t * (2f - t));
	public static float InOutQuad(float start, float end, float t) => Mathf.Lerp(start, end, t < 0.5f ? 2f * t * t : -1f + (4f - 2f * t) * t);
	public static float OutInQuad(float start, float end, float t) => OutQuad(start, end, t);
	public static float InCubic(float start, float end, float t) => Mathf.Lerp(start, end, t * t * t);
	public static float OutCubic(float start, float end, float t) { float u = t - 1f; return Mathf.Lerp(start, end, u * u * u + 1f); }
	public static float InOutCubic(float start, float end, float t) => Mathf.Lerp(start, end, t < 0.5f ? 4f * t * t * t : (t - 1f) * (2f * t - 2f) * (2f * t - 2f) + 1f);
	public static float OutInCubic(float start, float end, float t) => OutCubic(start, end, t);
	public static float InQuart(float start, float end, float t) => Mathf.Lerp(start, end, t * t * t * t);
	public static float OutQuart(float start, float end, float t) { float u = t - 1f; return Mathf.Lerp(start, end, 1f - u * u * u * u); }
	public static float InOutQuart(float start, float end, float t) { float u = t - 1f; return Mathf.Lerp(start, end, t < 0.5f ? 8f * t * t * t * t : 1f - 8f * u * u * u * u); }
	public static float OutInQuart(float start, float end, float t) => OutQuart(start, end, t);
	public static float InQuint(float start, float end, float t) => Mathf.Lerp(start, end, t * t * t * t * t);
	public static float OutQuint(float start, float end, float t) { float u = t - 1f; return Mathf.Lerp(start, end, 1f + u * u * u * u * u); }
	public static float InOutQuint(float start, float end, float t) { float u = t - 1f; return Mathf.Lerp(start, end, t < 0.5f ? 16f * t * t * t * t * t : 1f + 16f * u * u * u * u * u); }
	public static float OutInQuint(float start, float end, float t) => OutQuint(start, end, t);
	public static float InSin(float start, float end, float t) => Mathf.Lerp(start, end, 1f - Mathf.Cos(t * Mathf.PI * 0.5f));
	public static float OutSin(float start, float end, float t) => Mathf.Lerp(start, end, Mathf.Sin(t * Mathf.PI * 0.5f));
	public static float InOutSin(float start, float end, float t) => Mathf.Lerp(start, end, 0.5f * (1f - Mathf.Cos(Mathf.PI * t)));
	public static float OutInSin(float start, float end, float t) => OutSin(start, end, t);
	public static float InExp(float start, float end, float t) => Mathf.Lerp(start, end, t <= 0f ? 0f : Mathf.Pow(2f, 10f * (t - 1f)));
	public static float OutExp(float start, float end, float t) => Mathf.Lerp(start, end, t >= 1f ? 1f : 1f - Mathf.Pow(2f, -10f * t));
	public static float InOutExp(float start, float end, float t) => OutExp(start, end, t);
	public static float OutInExp(float start, float end, float t) => OutExp(start, end, t);
	public static float InCirc(float start, float end, float t) => Mathf.Lerp(start, end, 1f - Mathf.Sqrt(Mathf.Max(0f, 1f - t * t)));
	public static float OutCirc(float start, float end, float t) { float u = t - 1f; return Mathf.Lerp(start, end, Mathf.Sqrt(Mathf.Max(0f, 1f - u * u))); }
	public static float InOutCirc(float start, float end, float t) => OutCirc(start, end, t);
	public static float OutInCirc(float start, float end, float t) => OutCirc(start, end, t);
	public static float InElastic(float start, float end, float t) => OutBack(start, end, t);
	public static float OutElastic(float start, float end, float t) => OutBack(start, end, t);
	public static float InOutElastic(float start, float end, float t) => InOutBack(start, end, t);
	public static float OutInElastic(float start, float end, float t) => OutBack(start, end, t);
	public static float InBounce(float start, float end, float t) => start + (end - start) * (1f - OutBounce(0f, 1f, 1f - t));
	public static float OutBounce(float start, float end, float t)
	{
		float v;
		if (t < 1f / 2.75f) v = 7.5625f * t * t;
		else if (t < 2f / 2.75f) { t -= 1.5f / 2.75f; v = 7.5625f * t * t + 0.75f; }
		else if (t < 2.5f / 2.75f) { t -= 2.25f / 2.75f; v = 7.5625f * t * t + 0.9375f; }
		else { t -= 2.625f / 2.75f; v = 7.5625f * t * t + 0.984375f; }
		return start + (end - start) * v;
	}
	public static float InOutBounce(float start, float end, float t) => OutBounce(start, end, t);
	public static float OutInBounce(float start, float end, float t) => OutBounce(start, end, t);
	public static float InBack(float start, float end, float t) { const float s = 1.70158f; return start + (end - start) * (t * t * ((s + 1f) * t - s)); }
	public static float OutBack(float start, float end, float t) { const float s = 1.70158f; float u = t - 1f; return start + (end - start) * (u * u * ((s + 1f) * u + s) + 1f); }
	public static float InOutBack(float start, float end, float t) => OutBack(start, end, t);
	public static float OutInBack(float start, float end, float t) => OutBack(start, end, t);
}
