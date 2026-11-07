using System.Collections.Generic;
using UnityEngine;

public class NearestVertGravity : MonoBehaviour
{
	public Collider GravityCollider;

	public bool SetWorldUp;

	public bool SetModelRotation;

	public GameObject nearest;

	public Transform CheckTransform;

	public bool FlipOnHitByGolfBall;

	public float upwardsImpulseOnHit;

	public List<Transform> ModelsToMatchUpWith;

	private ConstantForce constForce;

	private Vector3 lastUp;

	private Rigidbody rigid;

	private float delay;

	private bool isFlipped;

	private float magnitude;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
