using System.Collections.Generic;
using UnityEngine;

public class MoveRigidBodyToTarget : MonoBehaviour
{
	[SerializeField]
	private Transform target;

	[SerializeField]
	private float tolerance;

	[SerializeField]
	private float speed;

	[SerializeField]
	private bool makeKinematicOnComplete;

	private List<Rigidbody> rbs;

	public void DeregisterRigidbody()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void FixedUpdate()
	{
	}
}
