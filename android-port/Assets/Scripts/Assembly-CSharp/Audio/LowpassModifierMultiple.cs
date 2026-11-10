using UnityEngine;

namespace Audio
{
	public class LowpassModifierMultiple : BaseAudioModifierMultiple
	{
		public float baseFrequency;

		public AudioLowPassFilter lowpassFilter;

		public override void Initialize()
		{
			if (lowpassFilter == null)
				lowpassFilter = GetComponent<AudioLowPassFilter>();
			if (lowpassFilter == null && gameObject != null)
				lowpassFilter = gameObject.AddComponent<AudioLowPassFilter>();
			if (lowpassFilter != null)
				lowpassFilter.cutoffFrequency = baseFrequency;
		}

		protected override void UpdateModifier()
		{
			if (lowpassFilter != null)
				lowpassFilter.cutoffFrequency = output + baseFrequency;
		}
	}
}
