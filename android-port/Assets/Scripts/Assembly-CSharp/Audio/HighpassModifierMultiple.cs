using UnityEngine;

namespace Audio
{
	public class HighpassModifierMultiple : BaseAudioModifierMultiple
	{
		public float baseFrequency;

		public AudioHighPassFilter highPassFilter;

		public override void Initialize()
		{
		}

		protected override void UpdateModifier()
		{
		}
	}
}
