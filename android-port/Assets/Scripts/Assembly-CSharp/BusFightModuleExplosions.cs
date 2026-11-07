using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusFightModuleExplosions : MonoBehaviour
{
	public AudioClip sfxExplosionBig;

	public List<AudioClip> sfxExplosions;

	public float smallVolumeMin;

	public float smallVolumeMax;

	public float smallPitchMin;

	public float smallPitchMax;

	public ParticleSystem button;

	public ParticleSystem hatch;

	public ParticleSystem big;

	public List<ParticleSystem> smaller;

	public List<ParticleSystem> smoke;

	public void ExplodeButton()
	{
	}

	public void ExplodeHatch()
	{
	}

	public IEnumerator PlayExplodingSmallerRoutine()
	{
		return null;
	}

	public void ExplodeRandomSmaller()
	{
	}

	public void PlaySmoke()
	{
	}

	public IEnumerator ExplodeSmallerRoutine()
	{
		return null;
	}

	public void ExplodeAllSmaller()
	{
	}
}
