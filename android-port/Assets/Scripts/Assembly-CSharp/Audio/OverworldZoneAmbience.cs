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

		public float oneshotCooldown;

		public static Action<OverworldZoneAmbience> OnZoneEnter;

		public static Action<OverworldZoneAmbience> OnZoneExit;

		public AudioMixerSnapshot mixerSnapshot;

		public List<AmbientAudio> ambients { get; private set; }

		public float nextOneshotTime { get; set; }

		private void Awake()
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void OnTriggerExit2D(Collider2D other)
		{
		}
	}
}
