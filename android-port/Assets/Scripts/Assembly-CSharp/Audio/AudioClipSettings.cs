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
		public float Weight = 1f;
		public bool IsWeighted;
		private AudioSources m_ActualVoice;

		public AudioClipSettings(AudioClip clip, AudioAttribute volume, AudioAttribute pitch)
		{
			this.clip = clip;
			Volume = volume;
			Pitch = pitch;
		}

		public AudioClipSettings(AudioClip clip)
		{
			this.clip = clip;
			Volume = new AudioAttribute(1f, 0f, 0f);
			Pitch = new AudioAttribute(1f, 0f, 0f);
		}

		public AudioClipSettings()
		{
			Volume = new AudioAttribute(1f, 0f, 0f);
			Pitch = new AudioAttribute(1f, 0f, 0f);
		}

		public PlayClipInfo GetPlayInfo()
		{
			float vol = Volume.GetResult;
			float pit = Pitch.GetResult;
			return new PlayClipInfo
			{
				clip = clip,
				voice = voice,
				VolumeResult = vol <= 0f ? 1f : vol,
				PitchResult = Mathf.Abs(pit) < 0.01f ? 1f : pit
			};
		}

		public AudioSource Play(AudioSources targetVoice, Vector3 position, float delay = 0f)
		{
			if (clip == null) return null;
			var v = targetVoice ?? AudioUtility.GetVoice(voice);
			if (v == null) return null;
			var info = GetPlayInfo();
			if (delay > 0f)
				return v.PlaySimpleDelayed(clip, info.VolumeResult, info.PitchResult, position, delay);
			return v.PlaySimple(clip, info.VolumeResult, info.PitchResult, position);
		}

		public AudioSource Play(Vector3 position, float delay = 0f)
		{
			return Play(AudioUtility.GetVoice(voice), position, delay);
		}
	}
}
