using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnKinematicAllRigidsOnCollision : MonoBehaviour
{
	public bool setAllKinematicAtStart;

	public float massCoefficient;

	public LayerMask collisionMask;

	public bool trigger;

	public UnityEvent unityEventOnCollision;

	private List<Rigidbody> rigidbodies;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
