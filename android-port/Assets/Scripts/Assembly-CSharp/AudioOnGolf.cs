using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class AudioOnGolf : MonoBehaviour
{
	[Serializable]
	public class ClipsFromBoost
	{
		public List<AudioClip> clips;

		public float minBoost;

		public float maxBoost;

		public float minVolume;

		public float maxVolume;

		public float volumeVariation;

		public float minPitch;

		public float maxPitch;

		public float pitchVariation;
	}

	[SerializeField]
	private float delay;

	[SerializeField]
	private bool isSpatialAudio;

	[SerializeField]
	private GolfBallController golfball;

	[SerializeField]
	private Vector3 playBelowThreshold;

	[SerializeField]
	private Vector3 playAboveThreshold;

	[SerializeField]
	private bool localAxis;

	[SerializeField]
	private bool PlayShootOnAimStart;

	[SerializeField]
	private List<ClipsFromBoost> boostSoundSettings;

	[SerializeField]
	private bool resetDelayAfterFirstShot;

	[SerializeField]
	private bool VolumeByCooldown;

	[SerializeField]
	private float cooldown;

	[SerializeField]
	private float multiplyBy;

	[SerializeField]
	private bool VolumeByShotFrequency;

	[SerializeField]
	private int reduceOverShots;

	[SerializeField]
	private float frequencyCooldown;

	private int shots;

	private float shotTimer;

	private float lastBoost;

	private float multiply;

	private void Start()
	{
	}

	private void FPS_OnActualShoot(Vector3 boost)
	{
	}

	private void Golfball_OnPreShoot(Vector3 boost)
	{
	}

	private void Shoot()
	{
	}

	private void Update()
	{
	}

	private IEnumerator PlayAfterDelay()
	{
		return null;
	}
}
