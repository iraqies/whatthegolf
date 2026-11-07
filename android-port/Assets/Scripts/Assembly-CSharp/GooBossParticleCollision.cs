using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GooBossParticleCollision : MonoBehaviour
{
	private ParticleSystem part;

	public SphereCollider playerCollider;

	public PhysicMaterial noFrictionMaterial;

	public PhysicMaterial highFrictionMaterial;

	public ParticleSystem collisionParticles;

	private bool canPlayCollisionParticles;

	public List<ParticleCollisionEvent> collisionEvents;

	public UnityEvent ChangeController;

	private bool hasControllerChanged;

	private void Start()
	{
	}

	private void OnParticleCollision(GameObject other)
	{
	}

	private IEnumerator CoolDown()
	{
		return null;
	}
}
