using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;
using UnityEngine.AI;

public class RagdollOnSwing : MonoBehaviour
{
	public float minVelocity;

	public float fullVelocity;

	public float fullPitch;

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
	}

	private void Update()
	{
	}

	public void Reset(bool hasHitTarget)
	{
	}

	public void LaunchKid(Vector3 boost, Action<GameObject> onHitGround)
	{
	}

	public void InLineState(bool state)
	{
	}

	public void RunBack(Vector3 pos, Action<GameObject> onReachDestination = null)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private IEnumerator DelayedCallback()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private Vector3 PitchBoost(Vector3 boost)
	{
		return default;
	}

	public bool IsOutOfBounds()
	{
		return false;
	}
}
