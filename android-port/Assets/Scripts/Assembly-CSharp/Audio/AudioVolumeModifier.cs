using UnityEngine;

namespace Audio
{
	public class AudioVolumeModifier : BaseAudioModifier
	{
		public bool zeroVolumeBelowMinValue = true;

		public bool startOnFirstValueChange;

		public bool handlePlayback;

		public bool handleByValue;

		public bool handleByVolume;

		private AudioFromSurfaceModifier surfaceModifier;

		private float volume;

		private bool valueChanged;

		private void Awake()
		{
			surfaceModifier = GetComponent<AudioFromSurfaceModifier>();
			Initialize();
		}

		protected override void OnValueChange(float _value)
		{
			valueChanged = true;
			if (handlePlayback && handleByValue)
			{
				if (_value > minModifierValue && value < minModifierValue)
				{
					if (source != null)
						source.Play();
				}
				else if (_value < minModifierValue && value > minModifierValue)
				{
					if (source != null)
						source.Stop();
				}
			}
			value = _value;
			float t = (maxModifierValue != minModifierValue) ? ((value - minModifierValue) / (maxModifierValue - minModifierValue)) : 0f;
			volume = Mathf.Lerp(minSoundValue, maxSoundValue, t);
			if (zeroVolumeBelowMinValue && value < minModifierValue)
				volume = 0f;
			if (value > highestValue)
				highestValue = value;
		}

		private void Update()
		{
			if (source == null)
				return;
			if (startOnFirstValueChange && !valueChanged)
				return;

			if (surfaceModifier != null && surfaceModifier.enabled && surfaceModifier.muteOnTouching == surfaceModifier.TouchingAnySurface)
			{
				surfaceModifier.CanMute = false;
				source.mute = false;
				source.volume -= surfaceModifier.decayVolumePerSecond * Time.deltaTime;
				if (source.volume < surfaceModifier.volumeWhenoff)
					source.volume = surfaceModifier.volumeWhenoff;
				return;
			}

			if (fadeSpeed > 0.01f)
				source.volume = Mathf.MoveTowards(source.volume, volume, Time.unscaledDeltaTime * fadeSpeed);
			else
				source.volume = volume;

			if (handlePlayback && handleByVolume)
			{
				if (source.volume > 0.01f && !source.isPlaying)
					source.Play();
				else if (source.volume < 0.01f && source.isPlaying)
					source.Stop();
			}
		}
	}
}
