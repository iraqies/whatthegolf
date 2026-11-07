using System.Collections.Generic;
using UnityEngine;

public class PlantParticlesSpawner : GolfBehaviour
{
	public PlantParticles.PlantType type;

	public List<ParticleSystem> particles;

	public List<PlantParticles> plants;

	private int index;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Start()
	{
	}

	private void PlantParticlesSpawner_OnParticles(PlantParticles plant, int amount)
	{
	}
}
