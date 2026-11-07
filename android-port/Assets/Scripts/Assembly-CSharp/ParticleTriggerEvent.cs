using System.Collections.Generic;
using UnityEngine;

public class ParticleTriggerEvent : MonoBehaviour
{
	public WaterParticles SplashParticles;

	public bool ignoreSound;

	public float SizeMod;

	public WaterStreamSFX waterStreamSFX;

	private ParticleSystem particles;

	private List<ParticleSystem.Particle> enter;

	private void Awake()
	{
	}

	private void OnParticleTrigger()
	{
	}
}
