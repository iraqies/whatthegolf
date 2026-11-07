using UnityEngine;

namespace Triband.Core.ParticleSystemUtils
{
	public static class MinMaxCurveExtensions
	{
		public static float EvaluateWithSeed(this ParticleSystem.MinMaxCurve curve, float t, int seed)
		{
			float lerpFactor = Mathf.Abs(Mathf.Sin(seed * 12.9898f + t * 78.233f) * 43758.5453f);
			lerpFactor -= Mathf.Floor(lerpFactor);
			switch (curve.mode)
			{
				case ParticleSystemCurveMode.TwoConstants:
					return Mathf.Lerp(curve.constantMin, curve.constantMax, lerpFactor);
				case ParticleSystemCurveMode.Curve:
					return curve.curve != null ? curve.curve.Evaluate(t) : curve.constant;
				case ParticleSystemCurveMode.TwoCurves:
					float a = curve.curveMin != null ? curve.curveMin.Evaluate(t) : 0f;
					float b = curve.curveMax != null ? curve.curveMax.Evaluate(t) : 0f;
					return Mathf.Lerp(a, b, lerpFactor);
				default:
					return curve.constant;
			}
		}
	}
}
