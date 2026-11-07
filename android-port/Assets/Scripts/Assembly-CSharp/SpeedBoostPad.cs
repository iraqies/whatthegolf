using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostPad : MonoBehaviour
{
	public Vector3 ForceDirection;

	public float SpeedBoost;

	public ForceMode Mode;

	private List<Rigidbody> affectedRigidbodies;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnCollisionExit(Collision other)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
