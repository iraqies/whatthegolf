using UnityEngine;

namespace Audio
{
	public class AudioPitchModifier : BaseAudioModifier
	{
		private float pitch;

		private AudioPitchToTimeScale timescalePitcher;

		private void Awake()
		{
			timescalePitcher = GetComponent<AudioPitchToTimeScale>();
			Initialize();
			pitch = minSoundValue;
		}

		protected override void OnValueChange(float _value)
		{
			value = _value;
			float t = (maxModifierValue != minModifierValue) ? ((value - minModifierValue) / (maxModifierValue - minModifierValue)) : 0f;
			pitch = Mathf.Lerp(minSoundValue, maxSoundValue, t);
			if (value > highestValue)
				highestValue = value;
		}

		private void Update()
		{
			if (source == null)
				return;
			if (timescalePitcher != null && timescalePitcher.enabled)
			{
				timescalePitcher.basePitch = pitch;
				return;
			}
			source.pitch = Mathf.MoveTowards(source.pitch, pitch, Time.unscaledDeltaTime * fadeSpeed);
		}
	}
}
