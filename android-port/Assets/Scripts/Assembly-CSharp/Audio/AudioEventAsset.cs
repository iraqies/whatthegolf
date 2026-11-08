using UnityEngine;

namespace Audio
{
	public class AudioEventAsset : ScriptableObject
	{
		public bool debug;
		public AudioUtility.AudioManagerVoice voice;
		public float cooldown;
		public ClipSettingsCollection clips;

		private float nextSoundTime;
		private AudioSources m_useVoice;

		public float NextSoundTime
		{
			get => nextSoundTime;
			set => nextSoundTime = value;
		}

		public void ResetOnSceneLoad()
		{
			nextSoundTime = 0f;
		}

		public void Play(Vector3 position, float volumeMultiplier = 1f, float pitchMultiplier = 1f, bool disableSpatial = false)
		{
			if (Time.unscaledTime < nextSoundTime) return;
			nextSoundTime = Time.unscaledTime + cooldown;
			var v = AudioUtility.GetVoice(voice);
			clips?.Play(v, position, volumeMultiplier, pitchMultiplier, 0f, disableSpatial);
		}

		public void Play(Vector3 position, PlayClipOnAudioEvent.Overrides _override, float volumeMultiplier = 1f, float pitchMultiplier = 1f, bool disableSpatial = false)
		{
			float cd = (_override != null && _override.overrideCooldown) ? _override.cooldown : cooldown;
			if (Time.unscaledTime < nextSoundTime) return;
			nextSoundTime = Time.unscaledTime + cd;
			var v = (_override != null && _override.overrideVoice) ? AudioUtility.GetVoice(_override.voice) : AudioUtility.GetVoice(voice);
			float vol = (_override != null && _override.overrideVolume) ? _override.volume.GetResult * volumeMultiplier : volumeMultiplier;
			float pit = (_override != null && _override.overridePitch) ? _override.pitch.GetResult * pitchMultiplier : pitchMultiplier;
			float del = (_override != null && _override.overrideDelay) ? _override.delay : 0f;
			clips?.Play(v, position, vol, pit, del, disableSpatial);
		}

		public void PlayDelayed(Vector3 position, float delay, float volumeMultiplier = 1f, float pitchMultiplier = 1f)
		{
			var v = AudioUtility.GetVoice(voice);
			clips?.Play(v, position, volumeMultiplier, pitchMultiplier, delay, false);
		}
	}
}
