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
		public float volume = 0.6f;
		public float pitch = 1f;
		public float fadeTime = 0.5f;
		public float timeScalePitchAmount;
		public List<AudioClip> oneShotAmbients;
		public float oneShotIntervalWaitMax = 12f;
		public float oneShotIntervalWaitMin = 5f;
		public float oneShotVolumeMin = 0.35f;
		public float oneShotVolumeMax = 0.7f;
		public Fade currentFade;
		public Action onKill;

		private AudioSource lastOneshotSource;
		private AudioClip lastOneshotClip;
		private AudioSource loopSource;

		public float Gain { get; private set; } = 1f;
		public float nextOneShotAmbient { get; set; }

		private void Start()
		{
			OnSceneStart();
		}

		public void OnSceneStart()
		{
			if (clip != null)
			{
				if (loopSource == null)
				{
					loopSource = GetComponent<AudioSource>() ?? gameObject.AddComponent<AudioSource>();
				}
				loopSource.clip = clip;
				loopSource.loop = true;
				loopSource.spatialBlend = 0f;
				loopSource.volume = Mathf.Clamp(volume > 0f ? volume : 0.5f, 0f, 1f);
				loopSource.pitch = Mathf.Abs(pitch) > 0.05f ? pitch : 1f;
				if (!loopSource.isPlaying)
					loopSource.Play();
			}
			nextOneShotAmbient = Time.unscaledTime + UnityEngine.Random.Range(Mathf.Max(2f, oneShotIntervalWaitMin), Mathf.Max(5f, oneShotIntervalWaitMax));
		}

		private void Update()
		{
			UpdateAmbient();
		}

		public void UpdateAmbient()
		{
			if (oneShotAmbients != null && oneShotAmbients.Count > 0 && Time.unscaledTime >= nextOneShotAmbient)
			{
				nextOneShotAmbient = Time.unscaledTime + UnityEngine.Random.Range(Mathf.Max(3f, oneShotIntervalWaitMin), Mathf.Max(6f, oneShotIntervalWaitMax));
				var c = oneShotAmbients[UnityEngine.Random.Range(0, oneShotAmbients.Count)];
				if (c != null && AudioManager.Instance != null && AudioManager.Instance.ambientEffects != null)
				{
					float vol = UnityEngine.Random.Range(Mathf.Max(0.2f, oneShotVolumeMin), Mathf.Max(0.4f, oneShotVolumeMax));
					lastOneshotSource = AudioManager.Instance.ambientEffects.PlaySimple(c, vol, 1f, transform.position);
				}
			}
		}

		public bool Equals(AmbientAudio other)
		{
			return other != null && other.clip == clip;
		}
	}
}
