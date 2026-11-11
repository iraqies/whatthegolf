using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOfWar : MonoBehaviour
{
	public OverworldButton2D DoorToDisolveFog;

	public List<ParticleSystem> Particles;

	private bool isStopping;

	private ParticleSystem.Particle[] particles;

	private IEnumerator Start()
	{
		particles = new ParticleSystem.Particle[1000];
		DoorToDisolveFog.OnOpen += OnOpen;
		yield return null;
		if (DoorToDisolveFog.openOrOpening)
		{
			foreach (ParticleSystem particle in Particles)
			{
				particle.gameObject.SetActive(false);
			}
		}
		else
		{
			foreach (ParticleSystem particle2 in Particles)
			{
				particle2.Play();
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			OnOpen();
		}
	}

	private void OnEnable()
	{
		if (!isStopping)
		{
			foreach (ParticleSystem particle in Particles)
			{
				particle.Play();
			}
		}
	}

	private void OnOpen()
	{
		if (isStopping)
		{
			return;
		}
		isStopping = true;
		foreach (ParticleSystem particle in Particles)
		{
			particle.Stop();
			int num = particle.GetParticles(particles);
			for (int i = 0; i < num; i++)
			{
				particles[i].remainingLifetime = Random.RandomRange(0.6f, 0.75f);
			}
			particle.SetParticles(particles, num);
		}
	}
}
