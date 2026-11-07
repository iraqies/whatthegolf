using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Skeleton : MonoBehaviour
{
	public Rigidbody ballRb;

	public float upKickForce;

	public float forwardKickForce;

	public float kickRange;

	public float sightRange;

	public float timeBeforeStopChase;

	public float sightAngle;

	public float breakForce;

	public float rebuildTime;

	public Transform raycastOrigin;

	public float disableTimeAfterKick;

	public Rigidbody[] skeletonParts;

	public GameObject skeletonDead;

	public GameObject skeletonAlive;

	public Transform rebuildForceTarget;

	public Skeleton skeletonPrefab;

	private NavMeshAgent navAgent;

	private bool isAlive;

	private Rigidbody rigid;

	private NavMeshPath path;

	private float lastPlayerSighting;

	private Vector3 target;

	private float lastKickTime;

	private bool initialized;

	public float rebuildForce;

	public AnimationCurve rebuildForceCurve;

	private void Start()
	{
	}

	public void Initialize(Vector3 position, Quaternion rotation, Rigidbody ballRb, Skeleton prefab)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private IEnumerator DeathAndRebirth()
	{
		return null;
	}

	private void DoKick(Rigidbody other)
	{
	}

	private bool CanSee(GameObject obj)
	{
		return false;
	}

	private void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
