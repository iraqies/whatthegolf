using System;

namespace Audio
{
	[Serializable]
	public struct AudioAttribute
	{
		public float Value;

		public MinMax RandomRange;

		public float GetResult => 0f;

		public AudioAttribute(float val, float min, float max)
		{
			Value = 0f;
			RandomRange = null;
		}
	}
}
