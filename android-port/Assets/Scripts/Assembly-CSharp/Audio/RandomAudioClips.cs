using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
	[Serializable]
	public class RandomAudioClips
	{
		public enum Voice
		{
			ShortEffects = 0,
			UI = 1,
			Ambience = 2
		}

		[SerializeField]
		private AudioMixerGroup outputGroup;

		[SerializeField]
		private bool nonRepeating;

		[SerializeField]
		private bool playInOrder;

		[SerializeField]
		private List<AudioClip> clips;

		[SerializeField]
		private ClipSettingsCollection collection;

		[SerializeField]
		private bool useSourceSettings;

		[SerializeField]
		private bool overrideVolume;

		[SerializeField]
		private float baseVolume;

		[SerializeField]
		private float volumeDeviance;

		[SerializeField]
		private float volumeVelocityBonus;

		[SerializeField]
		private bool overridePitch;

		[SerializeField]
		private float basePitch;

		[SerializeField]
		private float pitchDeviance;

		[SerializeField]
		private float pitchVelocityBonus;

		[SerializeField]
		private bool overrideAttenuation;

		[SerializeField]
		private AnimationCurve attenuation;

		[SerializeField]
		private float maxDistance;

		[SerializeField]
		private bool overrideDoppler;

		[SerializeField]
		private float doppler;

		[SerializeField]
		private bool overrideSpread;

		[SerializeField]
		private float spread;

		public float delay;

		[SerializeField]
		private bool reverse;

		[SerializeField]
		private Voice voice;

		private float m_VolumeBonus;

		private float m_PitchBonus;

		private int lastIndex;

		private AudioSource lastAudioSource;

		private AudioClip lastClip;

		private Action<AudioSource> mod;

		public void SetReverse(bool reverse)
		{
		}

		public AudioSource GetCurrentAudioSource()
		{
			return null;
		}

		public AudioClip ReturnLastClip()
		{
			return null;
		}

		public void SetVelocityBonus(float volBonus = 0f, float pitchBonus = 0f)
		{
		}

		private AudioClip ReturnRandomClip()
		{
			return null;
		}

		public void SetModifier(Vector3 position, float volMod, float pitchMod)
		{
		}

		public void PlayRandomClipOnSource(AudioSource s, float volMod, float pitchMod)
		{
		}

		public void PlayRandomClipOnSource(AudioSource s)
		{
		}

		public void PlayRandomClip(Transform obj, float volumeModifier, float pitchModifier)
		{
		}

		public void PlayRandomClip(Transform obj = null)
		{
		}

		public void PlayRandomClip(float volumeModifier, float pitchModifier)
		{
		}

		public void PlayRandomClip(Vector3 pos, float volumeModifier, float pitchModifier)
		{
		}

		public void PlayRandomClip(Vector3 pos)
		{
		}

		private void Play(AudioClip clip)
		{
		}
	}
}
