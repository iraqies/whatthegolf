using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
	public class OverworldZoneAmbience : MonoBehaviour
	{
		public bool requireBallShape;

		public Transmogrif.BALLSHAPES[] requiredBallShapes;

		public bool wontStopOnExit;

		public ClipSettingsCollection oneshotOnZoneEnter;

		public float oneshotCooldown = 1f;

		public static Action<OverworldZoneAmbience> OnZoneEnter;

		public static Action<OverworldZoneAmbience> OnZoneExit;

		public AudioMixerSnapshot mixerSnapshot;

		public List<AmbientAudio> ambients { get; private set; }

		public float nextOneshotTime { get; set; }

		private void Awake()
		{
			ambients = new List<AmbientAudio>(GetComponentsInChildren<AmbientAudio>(true));
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other == null) return;
			var ball = other.GetComponent<OverworldBall2D>() ?? other.GetComponentInParent<OverworldBall2D>();
			if (ball == null) return;
			if (Time.time >= nextOneshotTime && oneshotOnZoneEnter != null && oneshotOnZoneEnter.Count > 0)
			{
				oneshotOnZoneEnter.Play(transform.position);
				nextOneshotTime = Time.time + oneshotCooldown;
			}
			if (mixerSnapshot != null && AudioManager.Instance != null)
				AudioManager.Instance.SetMixerSnapshot(mixerSnapshot, 0.5f);
			OnZoneEnter?.Invoke(this);
		}

		private void OnTriggerExit2D(Collider2D other)
		{
			if (other == null || wontStopOnExit) return;
			var ball = other.GetComponent<OverworldBall2D>() ?? other.GetComponentInParent<OverworldBall2D>();
			if (ball == null) return;
			OnZoneExit?.Invoke(this);
		}
	}
}
