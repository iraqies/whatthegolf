using UnityEngine;

namespace Audio
{
	public class HighpassModifierMultiple : BaseAudioModifierMultiple
	{
		public float baseFrequency;

		public AudioHighPassFilter highPassFilter;

		public override void Initialize()
		{
			if (highPassFilter == null)
				highPassFilter = GetComponent<AudioHighPassFilter>();
			if (highPassFilter == null && gameObject != null)
				highPassFilter = gameObject.AddComponent<AudioHighPassFilter>();
			if (highPassFilter != null)
				highPassFilter.cutoffFrequency = baseFrequency;
		}

		protected override void UpdateModifier()
		{
			if (highPassFilter != null)
				highPassFilter.cutoffFrequency = output + baseFrequency;
		}
	}
}
