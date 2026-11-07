using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
	public List<Transform> MagnetPoints;

	public BoxCollider EffectTrigger;

	public float MaxForce;

	public List<Rigidbody> affectedObjects;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
