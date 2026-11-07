using System;
using UnityEngine;

namespace Audio
{
	[Serializable]
	public class AudioClipSettings
	{
		public AudioClip clip;

		public AudioUtility.AudioManagerVoice voice;

		public AudioAttribute Volume;

		public AudioAttribute Pitch;

		public float Weight;

		public bool IsWeighted;

		private AudioSources m_ActualVoice;

		public AudioClipSettings(AudioClip clip, AudioAttribute volume, AudioAttribute pitch)
		{
		}

		public AudioClipSettings(AudioClip clip)
		{
		}

		public AudioClipSettings()
		{
		}

		public PlayClipInfo GetPlayInfo()
		{
			return default;
		}

		public AudioSource Play(AudioSources voice, Vector3 position, float delay = 0f)
		{
			return null;
		}

		public AudioSource Play(Vector3 position, float delay = 0f)
		{
			return null;
		}
	}
}
