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
	[SerializeField] private Vector3 playBelowThreshold = Vector3.one;
	[SerializeField] private Vector3 playAboveThreshold = -Vector3.one;
	[SerializeField] private bool localAxis;
	[SerializeField] private bool PlayShootOnAimStart;
	[SerializeField] private List<ClipsFromBoost> boostSoundSettings;
	[SerializeField] private bool resetDelayAfterFirstShot;
	[SerializeField] private bool VolumeByCooldown;
	[SerializeField] private float cooldown;
	[SerializeField] private float multiplyBy = 1f;
	[SerializeField] private bool VolumeByShotFrequency;
	[SerializeField] private int reduceOverShots = 5;
	[SerializeField] private float frequencyCooldown = 0.4f;

	private int shots;
	private float shotTimer;
	private float lastBoost;
	private float multiply = 1f;

	private void Start()
	{
		if (golfball == null)
			golfball = GetComponentInParent<GolfBallController>();
		if (golfball == null)
			return;

		if (!PlayShootOnAimStart)
		{
			golfball.OnPreShoot -= Golfball_OnPreShoot;
			golfball.OnPreShoot += Golfball_OnPreShoot;
			return;
		}

		lastBoost = 1f;
		var fps = GetComponentInParent<FirstPersonShooter>();
		if (fps != null)
		{
			fps.OnActualShoot -= FPS_OnActualShoot;
			fps.OnActualShoot += FPS_OnActualShoot;
			return;
		}
		golfball.OnAimStart -= Shoot;
		golfball.OnAimStart += Shoot;
	}

	private void OnDestroy()
	{
		if (golfball != null)
		{
			golfball.OnPreShoot -= Golfball_OnPreShoot;
			golfball.OnAimStart -= Shoot;
		}
		var fps = GetComponentInParent<FirstPersonShooter>();
		if (fps != null)
		{
			fps.OnActualShoot -= FPS_OnActualShoot;
		}
	}

	private void FPS_OnActualShoot(Vector3 boost)
	{
		lastBoost = boost.magnitude;
		Shoot();
	}

	private void Golfball_OnPreShoot(Vector3 boost)
	{
		if (!enabled)
			return;
		lastBoost = boost.magnitude;
		Vector3 checkBoost = boost;
		if (localAxis && golfball != null && golfball.transform != null)
		{
			checkBoost = golfball.transform.InverseTransformDirection(boost);
		}
		if (checkBoost.x > playBelowThreshold.x || checkBoost.y > playBelowThreshold.y || checkBoost.z > playBelowThreshold.z)
			return;
		if (checkBoost.x < playAboveThreshold.x || checkBoost.y < playAboveThreshold.y || checkBoost.z < playAboveThreshold.z)
			return;

		if (delay > 0f)
			StartCoroutine(PlayAfterDelay());
		else
			Shoot();
	}

	private void Shoot()
	{
		if (!enabled)
			return;

		if (VolumeByShotFrequency)
		{
			float ratio = reduceOverShots > 0 ? Mathf.Clamp01((float)shots / reduceOverShots) : 0f;
			multiply = 1f - multiplyBy * ratio;
			shotTimer = Time.time + frequencyCooldown;
		}
		else if (VolumeByCooldown)
		{
			multiply = Time.time < shotTimer ? multiplyBy : 1f;
		}
		else
		{
			multiply = 1f;
		}

		if (boostSoundSettings != null && boostSoundSettings.Count > 0 && AudioManager.Instance != null)
		{
			for (int i = 0; i < boostSoundSettings.Count; i++)
			{
				var b = boostSoundSettings[i];
				if (b == null || b.clips == null || b.clips.Count == 0)
					continue;
				if (lastBoost < b.minBoost || lastBoost > b.maxBoost)
					continue;

				float range = b.maxBoost - b.minBoost;
				float t = range > 1e-4f ? Mathf.Clamp01((lastBoost - b.minBoost) / range) : 1f;
				float vol = (Mathf.Lerp(b.minVolume, b.maxVolume, t) + UnityEngine.Random.Range(-b.volumeVariation, b.volumeVariation)) * multiply;
				float pit = Mathf.Lerp(b.minPitch, b.maxPitch, t) + UnityEngine.Random.Range(-b.pitchVariation, b.pitchVariation);

				if (multiply > 0.99f && VolumeByCooldown)
					shotTimer = Time.time + cooldown;

				var pool = isSpatialAudio ? AudioManager.Instance.shortEffects : AudioManager.Instance.uiEffects;
				if (pool == null)
					pool = AudioManager.Instance.shortEffects;
				if (pool != null)
				{
					var clip = b.clips[UnityEngine.Random.Range(0, b.clips.Count)];
					pool.PlaySimple(clip, vol, pit, transform.position, 0f, !isSpatialAudio);
				}
			}
		}

		shots = Mathf.Clamp(shots + 1, 0, Mathf.Max(1, reduceOverShots));
	}

	private void Update()
	{
		if (VolumeByShotFrequency && shots > 0 && Time.time >= shotTimer)
		{
			shots = Mathf.Max(0, shots - 1);
			shotTimer = Time.time + frequencyCooldown;
		}
	}

	private IEnumerator PlayAfterDelay()
	{
		yield return new WaitForSeconds(delay);
		if (resetDelayAfterFirstShot)
			delay = 0f;
		Shoot();
	}
}
