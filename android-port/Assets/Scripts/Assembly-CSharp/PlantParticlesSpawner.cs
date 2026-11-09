using System.Collections.Generic;
using System.Linq;
using CameraStack;
using UnityEngine;

public class PlantParticlesSpawner : GolfBehaviour
{
	public PlantParticles.PlantType type;

	public List<ParticleSystem> particles;

	public List<PlantParticles> plants;

	private int index;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		plants = FindObjectsOfType<PlantParticles>().Where(p => p != null && p.type == type).ToList();
		particles = GetComponentsInChildren<ParticleSystem>(true).ToList();
	}

	private void Start()
	{
		if (plants == null || plants.Count == 0)
			plants = FindObjectsOfType<PlantParticles>().Where(p => p != null && p.type == type).ToList();
		if (particles == null || particles.Count == 0)
			particles = GetComponentsInChildren<ParticleSystem>(true).ToList();

		if (plants != null)
		{
			for (int i = 0; i < plants.Count; i++)
			{
				if (plants[i] != null)
				{
					plants[i].OnParticles -= PlantParticlesSpawner_OnParticles;
					plants[i].OnParticles += PlantParticlesSpawner_OnParticles;
				}
			}
		}
	}

	private void PlantParticlesSpawner_OnParticles(PlantParticles plant, int amount)
	{
		if (plant == null || particles == null || particles.Count == 0)
			return;
		if (OverworldCamera.Instance != null && !OverworldCamera.Instance.IsWorldPosNearScreen(plant.transform.position, 0.25f))
			return;

		index = Mathf.Clamp(index, 0, particles.Count - 1);
		var ps = particles[index];
		if (ps != null)
		{
			ps.transform.position = plant.transform.position;
			ps.transform.rotation = plant.transform.rotation;
			ps.Emit(amount);
		}
		index = (index + 1) % particles.Count;
	}
}
