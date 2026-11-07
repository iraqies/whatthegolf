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
		return null;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnEnable()
	{
	}

	private void OnOpen()
	{
	}
}
