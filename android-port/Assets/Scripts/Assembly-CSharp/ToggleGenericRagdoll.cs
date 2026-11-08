using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ToggleGenericRagdoll : MonoBehaviour
{
	public bool is2D;

	public Animator Animator;

	public NavMeshAgent NavAgent;

	public List<Rigidbody> Rigidbodies;

	public List<Rigidbody2D> Rigidbodies2D;

	public bool SetMaxAngularVelocity;

	public Rigidbody2D GiveForceToRigidbodyOnRagdoll;

	public float ForceToGiveRigidbodyOnRagdoll;

	public float RightForceToGiveRigidbodyOnRagdoll;

	public float AngularForceToGiveRigidbodyOnRagdoll;

	private void Start()
	{
		if (is2D)
		{
			if (Rigidbodies2D == null || Rigidbodies2D.Count == 0)
				Rigidbodies2D = new List<Rigidbody2D>(GetComponentsInChildren<Rigidbody2D>());
			foreach (var rb in Rigidbodies2D)
			{
				if (rb != null)
					rb.isKinematic = true;
			}
		}
		else
		{
			if (Rigidbodies == null || Rigidbodies.Count == 0)
				Rigidbodies = new List<Rigidbody>(GetComponentsInChildren<Rigidbody>());
			foreach (var rb in Rigidbodies)
			{
				if (rb != null)
				{
					rb.isKinematic = true;
					if (SetMaxAngularVelocity)
						rb.maxAngularVelocity = 500f;
				}
			}
		}
	}

	public void RagdollOn() => ToggleRagdoll(true);

	public void RagdollOff() => ToggleRagdoll(false);

	private void ToggleRagdoll(bool ragdollOn)
	{
		if (NavAgent != null)
			NavAgent.enabled = !ragdollOn;
		if (Animator != null)
			Animator.enabled = !ragdollOn;

		if (is2D)
		{
			if (Rigidbodies2D == null || Rigidbodies2D.Count == 0)
				Rigidbodies2D = new List<Rigidbody2D>(GetComponentsInChildren<Rigidbody2D>());
			foreach (var rb in Rigidbodies2D)
			{
				if (rb == null) continue;
				rb.isKinematic = !ragdollOn;
				rb.collisionDetectionMode = rb.isKinematic
					? CollisionDetectionMode2D.Discrete
					: CollisionDetectionMode2D.Continuous;
			}
			if (ragdollOn && GiveForceToRigidbodyOnRagdoll != null)
			{
				Vector3 rand = Random.onUnitSphere;
				GiveForceToRigidbodyOnRagdoll.AddRelativeForce(new Vector2(rand.x, rand.y) * ForceToGiveRigidbodyOnRagdoll);
				GiveForceToRigidbodyOnRagdoll.AddForce(Vector2.right * RightForceToGiveRigidbodyOnRagdoll);
				GiveForceToRigidbodyOnRagdoll.AddTorque(AngularForceToGiveRigidbodyOnRagdoll);
			}
		}
		else
		{
			if (Rigidbodies == null || Rigidbodies.Count == 0)
				Rigidbodies = new List<Rigidbody>(GetComponentsInChildren<Rigidbody>());
			foreach (var rb in Rigidbodies)
			{
				if (rb == null) continue;
				rb.isKinematic = !ragdollOn;
				rb.collisionDetectionMode = rb.isKinematic
					? CollisionDetectionMode.ContinuousSpeculative
					: CollisionDetectionMode.ContinuousDynamic;
				rb.velocity = Vector3.zero;
				rb.angularVelocity = Vector3.zero;
			}
		}
	}

	public void SetVelocity(Vector3 force)
	{
		if (Rigidbodies == null || Rigidbodies.Count == 0)
			Rigidbodies = new List<Rigidbody>(GetComponentsInChildren<Rigidbody>());
		foreach (var rb in Rigidbodies)
		{
			if (rb != null)
				rb.velocity = force;
		}
	}
}
