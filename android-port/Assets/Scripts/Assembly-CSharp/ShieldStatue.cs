using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.AI;

public class ShieldStatue : MonoBehaviour
{
	public GolfBallController ballController;

	public Rigidbody ballRb;

	public float upKickForce;

	public float forwardKickForce;

	public float reactDistance;

	public float maxMoveDist;

	public float playerMaxSqrVelBeforeMove;

	public Collider vulnerableCollider;

	public float minBreakForce;

	public float targetSearchRadius;

	public int targetSearchAttempts;

	public float moveSpeed;

	public float rotationSpeed;

	public static List<ShieldStatue> existingStatues;

	private Coroutine move;

	private Vector3 startPosition;

	public Vector3 targetPosition;

	private NavMeshAgent navAgent;

	public Color debugColor;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void Start()
	{
	}

	private void MoveTowardsPlayer(Vector3 playerShootDir)
	{
	}

	private IEnumerator ScheduleTarget()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void BackToStart()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void DoKick(Rigidbody other)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
