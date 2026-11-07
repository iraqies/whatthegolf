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
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void ResetOnSceneLoad()
		{
		}

		public void Play(Vector3 position, float volumeMultiplier = 1f, float pitchMultiplier = 1f, bool disableSpatial = false)
		{
		}

		public void Play(Vector3 position, PlayClipOnAudioEvent.Overrides _override, float volumeMultiplier = 1f, float pitchMultiplier = 1f, bool disableSpatial = false)
		{
		}

		public void PlayDelayed(Vector3 position, float delay, float volumeMultiplier = 1f, float pitchMultiplier = 1f)
		{
		}
	}
}
