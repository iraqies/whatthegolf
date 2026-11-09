using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;
using UnityEngine.AI;

public class RagdollOnSwing : MonoBehaviour
{
	public float minVelocity = 5f;

	public float fullVelocity = 35f;

	public float fullPitch = 10f;

	public float fullSpin;

	public ClipSettingsCollection sfxOnShoot;

	public Transform RootBone;

	public GameObject Root;

	private Animator animator;

	private Action<GameObject> onHitGround;

	private Action<GameObject> onReachedDestination;

	private bool hasHitGround;

	private bool wentOutOfBounds;

	private Vector3 rootOffset;

	private Vector3 localPosition;

	private NavMeshAgent agent;

	public LayerMask collisionLayers;

	private Dictionary<Rigidbody, Vector3> origPositions;

	private Dictionary<Rigidbody, Quaternion> origRotations;

	private Rigidbody rootRigid;

	private bool _doCollisionChecks;

	private void Awake()
	{
		if (RootBone != null)
			rootRigid = RootBone.GetComponent<Rigidbody>();
		origPositions = new Dictionary<Rigidbody, Vector3>();
		origRotations = new Dictionary<Rigidbody, Quaternion>();
		agent = GetComponentInParent<NavMeshAgent>();
		animator = GetComponentInParent<Animator>();
		if (Root != null)
			rootOffset = Root.transform.position - transform.position;
		localPosition = transform.localPosition;
		Reset(false);

		var parentCol = GetComponentInChildren<Collider>();
		var cols = GetComponentsInChildren<Collider>();
		if (cols != null && parentCol != null)
		{
			for (int i = 0; i < cols.Length; i++)
			{
				if (cols[i] != null && cols[i] != parentCol)
					Physics.IgnoreCollision(parentCol, cols[i]);
			}
		}
	}

	private void Update()
	{
		if (transform.position.y < -30f && !wentOutOfBounds && _doCollisionChecks)
		{
			_doCollisionChecks = false;
			wentOutOfBounds = true;
			onHitGround?.Invoke(Root);
		}

		if (agent != null && agent.enabled && !agent.pathPending && !float.IsInfinity(agent.remainingDistance) && agent.pathStatus == NavMeshPathStatus.PathComplete)
		{
			if (agent.remainingDistance == 0f)
			{
				onReachedDestination?.Invoke(Root);
				agent.enabled = false;
			}
		}
	}

	public void Reset(bool hasHitTarget)
	{
		Transform parent = transform.parent;
		transform.SetParent(null);
		if (Root != null)
			Root.transform.position = transform.position + rootOffset;
		transform.SetParent(parent);
		transform.localPosition = localPosition;

		var rbs = gameObject.GetComponentsInChildren<Rigidbody>();
		if (rbs != null)
		{
			for (int i = 0; i < rbs.Length; i++)
			{
				var rb = rbs[i];
				if (rb == null) continue;
				rb.detectCollisions = false;
				var col = rb.gameObject.GetComponent<Collider>();
				if (col != null)
					col.enabled = false;
				rb.useGravity = false;
				rb.isKinematic = true;
				if (origPositions != null && origPositions.ContainsKey(rb))
				{
					rb.transform.localPosition = origPositions[rb];
					if (origRotations != null && origRotations.ContainsKey(rb))
						rb.transform.localRotation = origRotations[rb];
				}
				else
				{
					if (origPositions != null)
						origPositions[rb] = rb.transform.localPosition;
					if (origRotations != null)
						origRotations[rb] = rb.transform.localRotation;
				}
			}
		}

		hasHitGround = false;
		wentOutOfBounds = false;
		if (animator != null)
			animator.enabled = true;
	}

	public void LaunchKid(Vector3 boost, Action<GameObject> onHitGround)
	{
		if (Root != null)
			Root.transform.SetParent(null);

		Vector3 crossUp = Vector3.Cross(boost, Vector3.up);
		Vector3 pitched = Quaternion.AngleAxis(fullPitch * boost.magnitude, crossUp) * boost;
		Vector3 torqueAxis = -Vector3.Cross(boost, Vector3.up);

		var rbs = gameObject.GetComponentsInChildren<Rigidbody>();
		if (rbs != null)
		{
			float mag = Mathf.Clamp01(pitched.magnitude);
			Vector3 dir = pitched.normalized;
			Vector3 vel = Vector3.Lerp(dir * minVelocity, dir * fullVelocity, mag);
			for (int i = 0; i < rbs.Length; i++)
			{
				var rb = rbs[i];
				if (rb == null) continue;
				rb.detectCollisions = true;
				var col = rb.gameObject.GetComponent<Collider>();
				if (col != null)
					col.enabled = true;
				rb.useGravity = true;
				rb.isKinematic = false;
				rb.AddForce(vel, ForceMode.VelocityChange);
				rb.AddTorque(torqueAxis * fullSpin, ForceMode.VelocityChange);
			}
		}

		if (animator != null)
		{
			animator.SetBool("Idle", true);
			animator.enabled = false;
		}
		this.onHitGround = onHitGround;
		hasHitGround = false;
		wentOutOfBounds = false;
		_doCollisionChecks = true;
	}

	public void InLineState(bool state)
	{
		if (animator != null)
			animator.SetBool("Idle", state);
	}

	public void RunBack(Vector3 pos, Action<GameObject> onReachDestination = null)
	{
		if (agent == null)
			return;
		if (Root != null)
			Root.transform.rotation = Quaternion.identity;
		if (wentOutOfBounds)
		{
			if (Root != null)
				Root.transform.position = pos;
			onReachDestination?.Invoke(Root);
			return;
		}

		agent.enabled = true;
		if (NavMesh.SamplePosition(transform.position, out var hit, 5f, -1))
			agent.Warp(hit.position);
		if (agent.SetDestination(pos))
		{
			onReachedDestination = onReachDestination;
		}
		else
		{
			agent.enabled = false;
			if (Root != null)
				Root.transform.position = pos;
			onReachDestination?.Invoke(Root);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (!_doCollisionChecks || hasHitGround || other == null || other.gameObject == null)
			return;
		int layer = other.gameObject.layer;
		if (((collisionLayers.value >> layer) & 1) != 0)
		{
			hasHitGround = true;
			StartCoroutine(DelayedCallback());
			_doCollisionChecks = false;
		}
	}

	private IEnumerator DelayedCallback()
	{
		float maxSeconds = 2f;
		while (maxSeconds > 0f && rootRigid != null && rootRigid.velocity.magnitude > 0.25f)
		{
			maxSeconds -= Time.deltaTime;
			yield return null;
		}
		onHitGround?.Invoke(Root);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!_doCollisionChecks || other == null)
			return;
		if (other.CompareTag("OutOfBounds"))
		{
			wentOutOfBounds = true;
			if (!hasHitGround)
			{
				hasHitGround = true;
				onHitGround?.Invoke(Root);
				_doCollisionChecks = false;
			}
		}
	}

	private Vector3 PitchBoost(Vector3 boost)
	{
		Vector3 axis = Vector3.Cross(boost, Vector3.up);
		return Quaternion.AngleAxis(fullPitch * boost.magnitude, axis) * boost;
	}

	public bool IsOutOfBounds()
	{
		return wentOutOfBounds;
	}
}
