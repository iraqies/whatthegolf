using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
	public class AmbientAudio : MonoBehaviour, IEquatable<AmbientAudio>
	{
		public enum Fade
		{
			None = 0,
			Down = 1,
			Up = 2
		}

		public AudioClip clip;

		public AudioMixerGroup mixerGroup;

		public bool startRandom;

		public float volume;

		public float pitch;

		public float fadeTime;

		public float timeScalePitchAmount;

		public List<AudioClip> oneShotAmbients;

		public float oneShotIntervalWaitMax;

		public float oneShotIntervalWaitMin;

		public float oneShotVolumeMin;

		public float oneShotVolumeMax;

		public Fade currentFade;

		public Action onKill;

		private AudioSource lastOneshotSource;

		private AudioClip lastOneshotClip;

		public float Gain { get; private set; }

		public float nextOneShotAmbient { get; set; }

		public void OnSceneStart()
		{
		}

		public void UpdateAmbient()
		{
		}

		public bool Equals(AmbientAudio other)
		{
			return false;
		}
	}
}
