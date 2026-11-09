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

		public void Play()
		{
			Play(Vector3.zero, 1f, 1f);
		}

		public void Play(Vector3 position, float volumeMultiplier = 1f, float pitchMultiplier = 1f, bool disableSpatial = false)
		{
			if (Time.time < nextSoundTime) return;
			if (m_useVoice == null)
				m_useVoice = AudioUtility.GetVoice(voice);
			clips?.Play(m_useVoice, position, volumeMultiplier, pitchMultiplier, 0f, disableSpatial);
			nextSoundTime = Time.time + cooldown;
		}

		public void Play(Vector3 position, PlayClipOnAudioEvent.Overrides _override, float volumeMultiplier = 1f, float pitchMultiplier = 1f, bool disableSpatial = false)
		{
			float cd = (_override != null && _override.overrideCooldown) ? _override.cooldown : cooldown;
			if (Time.time < nextSoundTime) return;
			var v = (_override != null && _override.overrideVoice) ? AudioUtility.GetVoice(_override.voice) : (m_useVoice ?? (m_useVoice = AudioUtility.GetVoice(voice)));
			float vol = (_override != null && _override.overrideVolume) ? _override.volume.GetResult * volumeMultiplier : volumeMultiplier;
			float pit = (_override != null && _override.overridePitch) ? _override.pitch.GetResult * pitchMultiplier : pitchMultiplier;
			float del = (_override != null && _override.overrideDelay) ? _override.delay : 0f;
			clips?.Play(v, position, vol, pit, del, disableSpatial);
			nextSoundTime = Time.time + cd;
		}

		public void PlayDelayed(Vector3 position, float delay, float volumeMultiplier = 1f, float pitchMultiplier = 1f)
		{
			if (Time.time < nextSoundTime) return;
			if (m_useVoice == null)
				m_useVoice = AudioUtility.GetVoice(voice);
			clips?.Play(m_useVoice, position, volumeMultiplier, pitchMultiplier, delay, false);
			nextSoundTime = Time.time + cooldown;
		}
	}
}
