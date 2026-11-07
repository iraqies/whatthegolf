using System.Collections.Generic;
using UnityEngine;

public class WaterParticles : MonoBehaviour
{
	public ParticleSystem SplashParticles;

	public ParticleSystem WaterSplash;

	public Vector3 SplashOffset;

	public int ParticlesToEmit;

	public List<AudioClip> SplashClips;

	public float SplashVolume;

	public float SizeMod;

	public Vector2 SizeRange;

	private ParticleSystem.EmitParams emitParams;

	private ParticleSystem.EmitParams waterParams;

	private Transform root;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void DoSplash(Vector3 position, Bounds bounds, bool onlyRings = false, bool ignoreSound = false)
	{
	}
}
