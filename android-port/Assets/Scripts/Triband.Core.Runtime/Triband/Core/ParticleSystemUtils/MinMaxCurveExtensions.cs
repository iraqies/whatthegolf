using UnityEngine;

namespace Triband.Core.ParticleSystemUtils
{
	public static class MinMaxCurveExtensions
	{
		public static float EvaluateWithSeed(this ParticleSystem.MinMaxCurve curve, float t, int seed)
		{
			float lerpFactor = Mathf.Abs(Mathf.Sin(seed * 12.9898f + t * 78.233f) * 43758.5453f);
			lerpFactor -= Mathf.Floor(lerpFactor);
			return curve.Evaluate(t, lerpFactor);
		}
	}
}
