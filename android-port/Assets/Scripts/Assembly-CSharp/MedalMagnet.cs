using System.Collections.Generic;
using UnityEngine;

public class MedalMagnet : MonoBehaviour
{
	public List<Transform> MagnetPoints;

	public SphereCollider EffectTrigger;

	public float maxForce;

	public float minForceMultiplier;

	public List<Rigidbody> affectedObjects;

	private Rigidbody rbody;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
