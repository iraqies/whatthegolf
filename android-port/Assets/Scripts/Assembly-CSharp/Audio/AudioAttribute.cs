using System;
using UnityEngine;

namespace Audio
{
	[Serializable]
	public struct AudioAttribute
	{
		public float Value;
		public MinMax RandomRange;

		public float GetResult
		{
			get
			{
				float baseVal = Value <= 0f ? 1f : Value;
				if (RandomRange != null && (RandomRange.min != 0f || RandomRange.max != 0f))
					return baseVal + UnityEngine.Random.Range(RandomRange.min, RandomRange.max);
				return baseVal;
			}
		}

		public AudioAttribute(float val, float min, float max)
		{
			Value = val;
			RandomRange = new MinMax(min, max);
		}
	}
}
