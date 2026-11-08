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

		[SerializeField] private AudioMixerGroup outputGroup;
		[SerializeField] private bool nonRepeating;
		[SerializeField] private bool playInOrder;
		[SerializeField] private List<AudioClip> clips;
		[SerializeField] private ClipSettingsCollection collection;
		[SerializeField] private bool useSourceSettings;
		[SerializeField] private bool overrideVolume;
		[SerializeField] private float baseVolume = 1f;
		[SerializeField] private float volumeDeviance;
		[SerializeField] private float volumeVelocityBonus;
		[SerializeField] private bool overridePitch;
		[SerializeField] private float basePitch = 1f;
		[SerializeField] private float pitchDeviance;
		[SerializeField] private float pitchVelocityBonus;
		[SerializeField] private bool overrideAttenuation;
		[SerializeField] private AnimationCurve attenuation;
		[SerializeField] private float maxDistance = 30f;
		[SerializeField] private bool overrideDoppler;
		[SerializeField] private float doppler;
		[SerializeField] private bool overrideSpread;
		[SerializeField] private float spread;
		public float delay;
		[SerializeField] private bool reverse;
		[SerializeField] private Voice voice;

		private float m_VolumeBonus;
		private float m_PitchBonus;
		private int lastIndex;
		private AudioSource lastAudioSource;
		private AudioClip lastClip;
		private Action<AudioSource> mod;

		public void SetReverse(bool rev) => reverse = rev;
		public AudioSource GetCurrentAudioSource() => lastAudioSource;
		public AudioClip ReturnLastClip() => lastClip;

		public void SetVelocityBonus(float volBonus = 0f, float pitchBonus = 0f)
		{
			m_VolumeBonus = volBonus;
			m_PitchBonus = pitchBonus;
		}

		private AudioClip ReturnRandomClip()
		{
			if (clips == null || clips.Count == 0) return null;
			if (playInOrder)
			{
				var c = clips[lastIndex % clips.Count];
				lastIndex = (lastIndex + 1) % clips.Count;
				lastClip = c;
				return c;
			}
			lastClip = clips[UnityEngine.Random.Range(0, clips.Count)];
			return lastClip;
		}

		public void SetModifier(Vector3 position, float volMod, float pitchMod) { }

		public void PlayRandomClipOnSource(AudioSource s, float volMod, float pitchMod)
		{
			var c = ReturnRandomClip();
			if (s != null && c != null)
			{
				s.clip = c;
				s.volume = Mathf.Clamp((baseVolume > 0f ? baseVolume : 1f) * volMod, 0f, 1.5f);
				s.pitch = Mathf.Clamp((Mathf.Abs(basePitch) > 0.05f ? basePitch : 1f) * pitchMod, 0.25f, 3f);
				s.Play();
				lastAudioSource = s;
			}
		}

		public void PlayRandomClipOnSource(AudioSource s) => PlayRandomClipOnSource(s, 1f, 1f);

		public void PlayRandomClip(Transform obj, float volumeModifier, float pitchModifier)
		{
			PlayRandomClip(obj != null ? obj.position : Vector3.zero, volumeModifier, pitchModifier);
		}

		public void PlayRandomClip(Transform obj = null)
		{
			PlayRandomClip(obj != null ? obj.position : Vector3.zero, 1f, 1f);
		}

		public void PlayRandomClip(float volumeModifier, float pitchModifier)
		{
			PlayRandomClip(Vector3.zero, volumeModifier, pitchModifier);
		}

		public void PlayRandomClip(Vector3 pos, float volumeModifier, float pitchModifier)
		{
			if (collection != null && collection.Count > 0)
			{
				collection.Play(pos, volumeModifier, pitchModifier);
				lastAudioSource = collection.LastAudioSource;
				return;
			}
			var c = ReturnRandomClip();
			if (c != null && AudioManager.Instance != null)
			{
				var v = voice == Voice.UI ? AudioManager.Instance.uiEffects : (voice == Voice.Ambience ? AudioManager.Instance.ambientEffects : AudioManager.Instance.shortEffects);
				float vol = (baseVolume > 0f ? baseVolume : 1f) * volumeModifier;
				float pit = (Mathf.Abs(basePitch) > 0.05f ? basePitch : 1f) * pitchModifier;
				lastAudioSource = v?.PlaySimple(c, vol, pit, pos);
			}
		}

		public void PlayRandomClip(Vector3 pos) => PlayRandomClip(pos, 1f, 1f);
		private void Play(AudioClip clip) { }
	}
}
