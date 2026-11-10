using System;
using System.Collections.Generic;
using UnityEngine;

public class Arrow3D : MonoBehaviour
{
	public List<Collider> Colliders;

	public Rigidbody Rigidbody;

	public Action OnHitGoal;

	public Action OnMissGoal;

	public LayerMask HitLayers = ~0;

	public Action OnReset;

	public bool CanWin = true;

	public bool Initialized;

	public bool stuck;

	private RotateWithVelocity rotator;

	public bool shouldStick = true;

	[NonSerialized]
	public string golfGoalLayerTag = "GolfFlag";

	[SerializeField]
	private float minPenetration = 0.5f;

	[SerializeField]
	private float maxPenetration = 1f;

	[SerializeField]
	private float additionalHitForce = 20f;

	[SerializeField]
	private float penetrationFactor = 0.75f;

	public Action<Collision> OnCollisionEnterExtraActions;

	private float lastVelBeforeHit;

	private Quaternion lastRotationBeforeHit;

	private Vector3 lastPositionBeforeHit;

	private float collisionVel;

	private Collision collision;

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

	private void FixedUpdate()
	{
		if (!stuck && Rigidbody != null)
		{
			lastVelBeforeHit = Rigidbody.velocity.magnitude;
			lastRotationBeforeHit = transform.rotation;
			lastPositionBeforeHit = transform.position;
		}
	}

	private void HitSomething(Collision collision)
	{
		if (collision == null || stuck)
			return;
		Collider hitCol = collision.collider;
		if (hitCol == null || hitCol.gameObject == null)
			return;
		int mask = HitLayers;
		if ((mask | (1 << hitCol.gameObject.layer)) != mask)
			return;

		OnCollisionEnterExtraActions?.Invoke(collision);
		stuck = true;
		if (rotator != null)
			Destroy(rotator);

		if (shouldStick)
		{
			collisionVel = lastVelBeforeHit;
			if (Rigidbody != null)
				Destroy(Rigidbody);
			if (Colliders != null)
			{
				foreach (Collider col in Colliders)
				{
					if (col != null)
						Destroy(col);
				}
			}
			enabled = false;
			transform.rotation = lastRotationBeforeHit;
			if (collision.contacts != null && collision.contacts.Length > 0)
			{
				Vector3 contactPt = collision.contacts[0].point;
				transform.position = contactPt + (lastPositionBeforeHit - contactPt) * (1f - penetrationFactor);
			}
			Transform parentTrans = (hitCol.attachedRigidbody != null) ? hitCol.attachedRigidbody.transform : hitCol.transform;
			transform.SetParent(parentTrans, true);
		}

		if (hitCol.attachedRigidbody != null)
		{
			hitCol.attachedRigidbody.AddForceAtPosition(transform.forward * additionalHitForce, transform.position, ForceMode.Impulse);
		}

		if (CanWin && hitCol.gameObject.tag == golfGoalLayerTag)
		{
			OnHitGoal?.Invoke();
			return;
		}

		if (!shouldStick && Rigidbody != null)
		{
			Rigidbody.velocity = Vector3.zero;
			Rigidbody.angularVelocity = Vector3.zero;
		}
		OnMissGoal?.Invoke();
	}

	private void OnCollisionEnter(Collision col)
	{
		HitSomething(col);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.CompareTag("Killzone"))
		{
			OnReset?.Invoke();
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
