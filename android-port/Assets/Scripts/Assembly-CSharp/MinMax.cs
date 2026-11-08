using System;
using UnityEngine;

[Serializable]
public class MinMax
{
	public float min;
	public float max;

	public MinMax(float min, float max)
	{
		this.min = min;
		this.max = max;
	}

	public float LerpInRange(float normalized)
	{
		return Mathf.Lerp(min, max, Mathf.Clamp01(normalized));
	}
}
