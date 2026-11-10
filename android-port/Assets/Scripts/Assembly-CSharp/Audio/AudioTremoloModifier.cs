using UnityEngine;

namespace Audio
{
	public class AudioTremoloModifier : BaseAudioModifier
	{
		public float minFrequency = 1f;

		public float maxFrequency = 10f;

		private float depth;

		private float frequency;

		private AudioTremolo tremolo;

		private void Awake()
		{
			tremolo = GetComponent<AudioTremolo>();
			Initialize();
			depth = minSoundValue;
		}

		protected override void OnValueChange(float _value)
		{
			value = _value;
			float t = (maxModifierValue != minModifierValue) ? ((value - minModifierValue) / (maxModifierValue - minModifierValue)) : 0f;
			depth = Mathf.Lerp(minSoundValue, maxSoundValue, t);
			frequency = Mathf.Lerp(minFrequency, maxFrequency, t);
			if (value > highestValue)
				highestValue = value;
		}

		private void Update()
		{
			if (source == null || tremolo == null)
				return;
			tremolo.SetFrequency(frequency);
			tremolo.SetDepth(depth);
		}
	}
}
