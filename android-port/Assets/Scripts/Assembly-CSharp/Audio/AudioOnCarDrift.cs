using System.Collections.Generic;
using Core;
using UnityEngine;

namespace Audio
{
	public class AudioOnCarDrift : MonoBehaviour
	{
		public float skidIntensity;

		public Skidmarks skid;

		public Rigidbody rigid;

		public GolfCarShooter car;

		public AnimationCurve amplitude;

		public float maxLoopVolume;

		public float minLoopPitch;

		public float maxLoopPitch;

		public List<AudioClip> oneshots;

		public float minIntensity;

		public float maxIntensity;

		public float minVolume;

		public float maxVolume;

		public float minPitch;

		public float maxPitch;

		public float cooldown;

		private AudioSource source;

		private AudioPitchToTimeScale timeScalePitcher;

		private float nextOneshotTime;

		private float targetIntensity;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnCreateSkidmark(float intensity)
		{
		}
	}
}
