using UnityEngine;

namespace Audio
{
	public class LowpassModifierMultiple : BaseAudioModifierMultiple
	{
		public float baseFrequency;

		public AudioLowPassFilter lowpassFilter;

		public override void Initialize()
		{
		}

		protected override void UpdateModifier()
		{
		}
	}
}
