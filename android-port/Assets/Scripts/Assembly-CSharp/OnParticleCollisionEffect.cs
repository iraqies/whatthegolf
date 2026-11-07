using System.Collections.Generic;
using UnityEngine;

public class OnParticleCollisionEffect : MonoBehaviour
{
	public ParticleSystem ParticlesToSpawn;

	public LayerMask AcceptedLayers;

	private ParticleSystem part;

	private List<ParticleCollisionEvent> collisionEvents;

	private void Start()
	{
	}

	private void OnParticleCollision(GameObject other)
	{
	}
}
