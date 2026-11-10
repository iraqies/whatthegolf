using System;
using UnityEngine;

public class Javelin : MonoBehaviour
{
	public Collider Collider;

	public Rigidbody Rigidbody;

	public Action OnHitGoal;

	public Action OnMissGoal;

	public LayerMask HitLayers = ~0;

	public Action OnReset;

	public bool CanWin = true;

	public bool Initialized;

	public bool stuck;

	private RotateWithVelocity rotator;

	private void OnEnable()
	{
		rotator = GetComponent<RotateWithVelocity>();
		if (rotator != null)
			rotator.enabled = true;
		stuck = false;
		if (Rigidbody != null)
		{
			Rigidbody.velocity = Vector3.zero;
			Rigidbody.angularVelocity = Vector3.zero;
		}
		Joint joint = GetComponent<Joint>();
		if (joint != null)
			Destroy(joint);
	}

	private void HitSomething(Collider hit)
	{
		if (stuck || hit == null || hit.gameObject == null)
			return;
		int mask = HitLayers;
		if ((mask | (1 << hit.gameObject.layer)) != mask)
			return;
		stuck = true;
		if (rotator != null)
			rotator.enabled = false;
		if (hit.attachedRigidbody != null)
		{
			FixedJoint joint = gameObject.AddComponent<FixedJoint>();
			if (joint != null)
				joint.connectedBody = hit.attachedRigidbody;
			hit.attachedRigidbody.AddForceAtPosition(transform.right * 20f, transform.position, ForceMode.Impulse);
		}
		else if (Rigidbody != null)
		{
			Rigidbody.isKinematic = true;
		}

		if (CanWin)
		{
			bool hitGoal = (hit.attachedRigidbody != null && hit.attachedRigidbody.GetComponent<GolfGoal>() != null)
				|| hit.gameObject.GetComponent<GolfGoal>() != null;
			if (hitGoal)
			{
				OnHitGoal?.Invoke();
				return;
			}
		}

		if (Rigidbody != null)
		{
			Rigidbody.velocity = Vector3.zero;
			Rigidbody.angularVelocity = Vector3.zero;
		}
		OnMissGoal?.Invoke();
	}

	private void OnCollisionEnter(Collision col)
	{
		if (col != null)
			HitSomething(col.collider);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null)
			return;
		if (other.CompareTag("Killzone"))
		{
			OnReset?.Invoke();
			return;
		}
		if (!other.isTrigger)
		{
			HitSomething(other);
		}
	}

	public void EnteredPortal(PortalPackage package)
	{
		if (!stuck)
			return;
		if (rotator != null)
			rotator.enabled = true;
		stuck = false;
		if (package != null && package.otherPortal != null)
		{
			transform.rotation = Quaternion.LookRotation(package.otherPortal.transform.forward);
		}
		if (Rigidbody != null)
		{
			float speed = UnityEngine.Random.Range(10f, 20f);
			Rigidbody.velocity = transform.forward * speed;
			Rigidbody.angularVelocity = Vector3.zero;
			Rigidbody.isKinematic = false;
		}
		Joint joint = GetComponent<Joint>();
		if (joint != null)
			Destroy(joint);
	}
}
