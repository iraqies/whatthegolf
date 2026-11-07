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
	}

	public void RagdollOn()
	{
	}

	public void RagdollOff()
	{
	}

	private void ToggleRagdoll(bool ragdollOn)
	{
	}

	public void SetVelocity(Vector3 force)
	{
	}
}
