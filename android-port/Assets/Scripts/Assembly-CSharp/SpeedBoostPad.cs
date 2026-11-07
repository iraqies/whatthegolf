using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostPad : MonoBehaviour
{
	public Vector3 ForceDirection = Vector3.forward;
	public float SpeedBoost = 25f;
	public ForceMode Mode = ForceMode.Acceleration;
	private List<Rigidbody> affectedRigidbodies = new List<Rigidbody>();

	private void Start() { }

	private void FixedUpdate()
	{
		affectedRigidbodies.RemoveAll(r => r == null);
		Vector3 worldDir = transform.TransformDirection(ForceDirection.normalized);
		foreach (var rb in affectedRigidbodies)
		{
			if (!rb.isKinematic)
				rb.AddForce(worldDir * SpeedBoost, Mode);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other?.rigidbody != null && !affectedRigidbodies.Contains(other.rigidbody))
			affectedRigidbodies.Add(other.rigidbody);
	}

	private void OnCollisionExit(Collision other)
	{
		if (other?.rigidbody != null)
			affectedRigidbodies.Remove(other.rigidbody);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other?.attachedRigidbody != null && !affectedRigidbodies.Contains(other.attachedRigidbody))
			affectedRigidbodies.Add(other.attachedRigidbody);
	}

	private void OnTriggerExit(Collider other)
	{
		if (other?.attachedRigidbody != null)
			affectedRigidbodies.Remove(other.attachedRigidbody);
	}

	private void OnDrawGizmosSelected() { }
}
