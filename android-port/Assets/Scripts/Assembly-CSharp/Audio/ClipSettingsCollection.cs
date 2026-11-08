using System;
using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	[Serializable]
	public class ClipSettingsCollection : IPlayableClipCollection, IWeightedCollection
	{
		public AudioAttribute Volume;
		public AudioAttribute Pitch;
		public CollectionPlayMode PlayMode;
		public List<AudioClipSettings> Clips;

		private AudioSource m_lastAudioSource;
		private PlayClipInfo m_lastClipInfo;
		private float[] weights;

		public CollectionPlayMode GetPlayMode => PlayMode;
		public int LastCollectionIndex { get; set; }
		public int Count => Clips != null ? Clips.Count : 0;
		public AudioSource LastAudioSource => m_lastAudioSource;
		public PlayClipInfo LastClipInfo => m_lastClipInfo;
		public float[] GetWeights => weights;

		public PlayClipInfo GetPlayInfo()
		{
			if (Clips == null || Clips.Count == 0) return default;
			int idx = UnityEngine.Random.Range(0, Clips.Count);
			if (Clips.Count > 1 && idx == LastCollectionIndex)
				idx = (idx + 1) % Clips.Count;
			LastCollectionIndex = idx;
			var item = Clips[idx];
			if (item == null || item.clip == null) return default;
			var info = item.GetPlayInfo();
			float colVol = Volume.GetResult;
			float colPit = Pitch.GetResult;
			if (colVol > 0f) info.VolumeResult *= colVol;
			if (Mathf.Abs(colPit) > 0.01f) info.PitchResult *= colPit;
			m_lastClipInfo = info;
			return info;
		}

		public void Play(Vector3 position, float volumeModifier = 1f, float pitchModifier = 1f)
		{
			var info = GetPlayInfo();
			if (info.clip == null) return;
			var v = AudioUtility.GetVoice(info.voice);
			if (v != null)
				m_lastAudioSource = v.PlaySimple(info.clip, info.VolumeResult * volumeModifier, info.PitchResult * pitchModifier, position);
		}

		public void PlayDelayed(Vector3 position, float delay, float volumeModifier = 1f, float pitchModifier = 1f)
		{
			var info = GetPlayInfo();
			if (info.clip == null) return;
			var v = AudioUtility.GetVoice(info.voice);
			if (v != null)
				m_lastAudioSource = v.PlaySimpleDelayed(info.clip, info.VolumeResult * volumeModifier, info.PitchResult * pitchModifier, position, delay);
		}

		public void PlayDelayed(Vector3 position, AudioSources voice, float delay, float volumeModifier = 1f, float pitchModifier = 1f)
		{
			var info = GetPlayInfo();
			if (info.clip == null) return;
			var v = voice ?? AudioUtility.GetVoice(info.voice);
			if (v != null)
				m_lastAudioSource = v.PlaySimpleDelayed(info.clip, info.VolumeResult * volumeModifier, info.PitchResult * pitchModifier, position, delay);
		}

		public void Play(AudioSources voice, Vector3 position, float delay = 0f)
		{
			Play(voice, position, 1f, 1f, delay, false);
		}

		public void Play(AudioSources voice, Vector3 position, float volumeModifier, float pitchModifier, float delay = 0f, bool disableSpatial = false)
		{
			var info = GetPlayInfo();
			if (info.clip == null) return;
			var v = voice ?? AudioUtility.GetVoice(info.voice);
			if (v == null) return;
			if (delay > 0f)
				m_lastAudioSource = v.PlaySimpleDelayed(info.clip, info.VolumeResult * volumeModifier, info.PitchResult * pitchModifier, position, delay);
			else
				m_lastAudioSource = v.PlaySimple(info.clip, info.VolumeResult * volumeModifier, info.PitchResult * pitchModifier, position, 0f, disableSpatial);
		}
	}
}
