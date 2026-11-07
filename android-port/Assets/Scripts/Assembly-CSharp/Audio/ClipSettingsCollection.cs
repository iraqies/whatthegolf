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

		public CollectionPlayMode GetPlayMode => CollectionPlayMode.RandomNonRepeating;

		public int LastCollectionIndex { get; set; }

		public int Count => 0;

		public AudioSource LastAudioSource => null;

		public PlayClipInfo LastClipInfo => default;

		public float[] GetWeights => null;

		public PlayClipInfo GetPlayInfo()
		{
			return default;
		}

		public void Play(Vector3 position, float volumeModifier = 1f, float pitchModifier = 1f)
		{
		}

		public void PlayDelayed(Vector3 position, float delay, float volumeModifier = 1f, float pitchModifier = 1f)
		{
		}

		public void PlayDelayed(Vector3 position, AudioSources voice, float delay, float volumeModifier = 1f, float pitchModifier = 1f)
		{
		}

		public void Play(AudioSources voice, Vector3 position, float delay = 0f)
		{
		}

		public void Play(AudioSources voice, Vector3 position, float volumeModifier, float pitchModifier, float delay = 0f, bool disableSpatial = false)
		{
		}
	}
}
