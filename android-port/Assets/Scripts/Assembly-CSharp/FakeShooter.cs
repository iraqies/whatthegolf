using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class FakeShooter : MonoBehaviour
{
	[SerializeField]
	private bool PlayOnAwake;

	[SerializeField]
	private bool ContinousAim;

	[SerializeField]
	private float ContinousAimTime;

	[SerializeField]
	private Vector3 aimVector;

	[SerializeField]
	private List<AudioClip> clips;

	[SerializeField]
	private float baseVolume = 1f;

	[SerializeField]
	private float volumeDeviance = 0.1f;

	[SerializeField]
	private float basePitch = 1f;

	[SerializeField]
	private float pitchDeviance = 0.1f;

	[SerializeField]
	private float minDistance = 20f;

	[SerializeField]
	private float maxDistance = 100f;

	[SerializeField]
	private HotdogGolfer golferForContinousAim;

	private void PlaySound()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
		{
			AudioManager.Instance.shortEffects.Play(clips, delegate(AudioSource s)
			{
				if (s != null)
				{
					s.transform.position = base.transform.position;
					s.volume = Random.Range(baseVolume - volumeDeviance, baseVolume + volumeDeviance);
					s.pitch = Random.Range(basePitch - pitchDeviance, basePitch + pitchDeviance);
					s.minDistance = minDistance;
					s.maxDistance = maxDistance;
				}
			}, true, 0f, false);
		}
	}

	private void Start()
	{
		if (PlayOnAwake)
		{
			Execute();
		}
	}

	public void Execute()
	{
		if (ContinousAim)
		{
			StartCoroutine(ExecuteCRAim());
		}
		else
		{
			StartCoroutine(ExecuteCR());
		}
	}

	private IEnumerator ExecuteCRAim()
	{
		HotdogGolfer golfer = GetComponent<HotdogGolfer>();
		PlaySound();
		yield return new WaitUntil(() => golfer == null || golfer.Puppet == null || golfer.Puppet.puppet != null);
		if (golfer != null)
		{
			golfer.OnAimUpdate(aimVector, false);
		}
		yield return new WaitForSeconds(ContinousAimTime);
		if (golfer != null)
		{
			golfer.OnShoot(aimVector);
		}
	}

	private IEnumerator ExecuteCR()
	{
		GolfBallController c = GetComponent<GolfBallController>();
		yield return new WaitUntil(() => c == null || c.shooter != null);
		yield return new WaitForSeconds(0.5f);
		PlaySound();
		if (c != null && c.shooter != null)
		{
			c.shooter.OnShoot(aimVector);
		}
	}
}
