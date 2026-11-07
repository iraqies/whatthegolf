using System.Collections.Generic;
using UnityEngine;

public class GolfRallyPerson : MonoBehaviour
{
	public LayerMask HitLayer;

	public List<Transform> UnChildThese;

	public float ForceOnHit;

	private Rigidbody[] rigidbodies;

	private Animator animator;

	private Collider mainCollider;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
