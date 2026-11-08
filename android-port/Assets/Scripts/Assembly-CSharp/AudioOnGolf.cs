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
		public float maxBoost = 1f;
		public float minVolume = 0.5f;
		public float maxVolume = 1f;
		public float volumeVariation;
		public float minPitch = 0.95f;
		public float maxPitch = 1.05f;
		public float pitchVariation;
	}

	[SerializeField] private float delay;
	[SerializeField] private bool isSpatialAudio;
	[SerializeField] private GolfBallController golfball;
	[SerializeField] private Vector3 playBelowThreshold;
	[SerializeField] private Vector3 playAboveThreshold;
	[SerializeField] private bool localAxis;
	[SerializeField] private bool PlayShootOnAimStart;
	[SerializeField] private List<ClipsFromBoost> boostSoundSettings;
	[SerializeField] private bool resetDelayAfterFirstShot;
	[SerializeField] private bool VolumeByCooldown;
	[SerializeField] private float cooldown;
	[SerializeField] private float multiplyBy = 1f;
	[SerializeField] private bool VolumeByShotFrequency;
	[SerializeField] private int reduceOverShots;
	[SerializeField] private float frequencyCooldown;

	private int shots;
	private float shotTimer;
	private float lastBoost;
	private float multiply = 1f;

	private void Start()
	{
		if (golfball == null)
			golfball = GetComponentInParent<GolfBallController>();
		if (golfball != null)
		{
			golfball.OnPreShoot += Golfball_OnPreShoot;
			if (PlayShootOnAimStart)
				golfball.OnAimStart += Shoot;
		}
	}

	private void OnDestroy()
	{
		if (golfball != null)
		{
			golfball.OnPreShoot -= Golfball_OnPreShoot;
			golfball.OnAimStart -= Shoot;
		}
	}

	private void FPS_OnActualShoot(Vector3 boost)
	{
		Golfball_OnPreShoot(boost);
	}

	private void Golfball_OnPreShoot(Vector3 boost)
	{
		lastBoost = boost.magnitude;
		if (delay > 0f)
			StartCoroutine(PlayAfterDelay());
		else
			Shoot();
	}

	private void Shoot()
	{
		shots++;
		if (boostSoundSettings != null && boostSoundSettings.Count > 0 && AudioManager.Instance != null)
		{
			var v = AudioManager.Instance.shortEffects;
			if (v != null)
			{
				foreach (var b in boostSoundSettings)
				{
					if (b == null || b.clips == null || b.clips.Count == 0) continue;
					var c = b.clips[UnityEngine.Random.Range(0, b.clips.Count)];
					float vol = b.maxVolume > 0f ? b.maxVolume : 0.9f;
					float pit = b.maxPitch > 0.1f ? b.maxPitch : 1f;
					v.PlaySimple(c, vol, pit, transform.position);
				}
			}
		}
	}

	private void Update()
	{
	}

	private IEnumerator PlayAfterDelay()
	{
		yield return new WaitForSeconds(delay);
		Shoot();
	}
}
