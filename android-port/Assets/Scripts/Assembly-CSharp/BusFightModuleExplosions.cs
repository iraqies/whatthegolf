using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusFightModuleExplosions : MonoBehaviour
{
	public AudioClip sfxExplosionBig;

	public List<AudioClip> sfxExplosions;

	public float smallVolumeMin = 0.7f;

	public float smallVolumeMax = 1f;

	public float smallPitchMin = 0.9f;

	public float smallPitchMax = 1.1f;

	public ParticleSystem button;

	public ParticleSystem hatch;

	public ParticleSystem big;

	public List<ParticleSystem> smaller;

	public List<ParticleSystem> smoke;

	public void ExplodeButton()
	{
		if (button != null)
		{
			button.Play();
		}
		if (sfxExplosionBig != null)
		{
			AudioManager.PlaySFX(sfxExplosionBig, transform.position);
		}
	}

	public void ExplodeHatch()
	{
		if (hatch != null)
		{
			hatch.Play();
		}
		if (sfxExplosionBig != null)
		{
			AudioManager.PlaySFX(sfxExplosionBig, transform.position);
		}
	}

	public IEnumerator PlayExplodingSmallerRoutine()
	{
		if (smaller == null || smaller.Count == 0)
		{
			yield break;
		}
		for (int i = 0; i < smaller.Count; i++)
		{
			ExplodeRandomSmaller();
			yield return new WaitForSeconds(0.15f);
		}
	}

	public void ExplodeRandomSmaller()
	{
		if (smaller != null && smaller.Count > 0)
		{
			ParticleSystem ps = smaller[Random.Range(0, smaller.Count)];
			if (ps != null)
			{
				ps.Play();
			}
		}
		if (sfxExplosions != null && sfxExplosions.Count > 0)
		{
			AudioClip clip = sfxExplosions[Random.Range(0, sfxExplosions.Count)];
			if (clip != null)
			{
				AudioManager.PlaySFX(clip, transform.position, Random.Range(smallVolumeMin, smallVolumeMax), Random.Range(smallPitchMin, smallPitchMax));
			}
		}
	}

	public void PlaySmoke()
	{
		if (smoke == null)
		{
			return;
		}
		for (int i = 0; i < smoke.Count; i++)
		{
			if (smoke[i] != null)
			{
				smoke[i].Play();
			}
		}
	}

	public IEnumerator ExplodeSmallerRoutine()
	{
		yield return StartCoroutine(PlayExplodingSmallerRoutine());
		if (big != null)
		{
			big.Play();
		}
		if (sfxExplosionBig != null)
		{
			AudioManager.PlaySFX(sfxExplosionBig, transform.position);
		}
		PlaySmoke();
	}

	public void ExplodeAllSmaller()
	{
		if (smaller != null)
		{
			for (int i = 0; i < smaller.Count; i++)
			{
				if (smaller[i] != null)
				{
					smaller[i].Play();
				}
			}
		}
		if (big != null)
		{
			big.Play();
		}
		if (sfxExplosionBig != null)
		{
			AudioManager.PlaySFX(sfxExplosionBig, transform.position);
		}
		PlaySmoke();
	}
}
