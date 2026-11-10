using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.AI;

public class ShieldStatue : MonoBehaviour
{
	public GolfBallController ballController;

	public Rigidbody ballRb;

	public float upKickForce = 50f;

	public float forwardKickForce = 50f;

	public float reactDistance = 50f;

	public float maxMoveDist = 10f;

	public float playerMaxSqrVelBeforeMove = 10f;

	public Collider vulnerableCollider;

	public float minBreakForce = 10f;

	public float targetSearchRadius = 15f;

	public int targetSearchAttempts = 5;

	public float moveSpeed = 10f;

	public float rotationSpeed = 100f;

	public static List<ShieldStatue> existingStatues = new List<ShieldStatue>();

	private Coroutine move;

	private Vector3 startPosition;

	public Vector3 targetPosition;

	private NavMeshAgent navAgent;

	public Color debugColor = Color.red;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		existingStatues = new List<ShieldStatue>();
	}

	private void Start()
	{
		startPosition = base.transform.position;
		targetPosition = base.transform.position;
		navAgent = GetComponent<NavMeshAgent>();
		if (ballController != null)
		{
			ballController.OnShoot += MoveTowardsPlayer;
		}
		if (Level.Instance != null)
		{
			Level.Instance.OnOutOfBounds += BackToStart;
		}
		if (existingStatues == null)
		{
			existingStatues = new List<ShieldStatue>();
		}
		existingStatues.Add(this);
	}

	private void MoveTowardsPlayer(Vector3 playerShootDir)
	{
		if (ballRb == null)
			return;

		if (Vector3.Distance(ballRb.position, base.transform.position) <= reactDistance)
		{
			if (move != null)
			{
				StopCoroutine(move);
			}
			move = StartCoroutine(ScheduleTarget());
		}
	}

	private IEnumerator ScheduleTarget()
	{
		yield return new WaitUntil(() => ballRb != null && ballRb.velocity.sqrMagnitude < playerMaxSqrVelBeforeMove);

		if (ballController == null)
			yield break;

		Vector3 toPlayer = ballController.transform.position - base.transform.position;
		targetPosition = base.transform.position + toPlayer.normalized * Mathf.Min(toPlayer.magnitude, maxMoveDist);

		bool validFound = false;
		for (int i = 0; i < targetSearchAttempts; i++)
		{
			if (validFound)
				yield break;

			bool overlapsOther = false;
			if (existingStatues != null)
			{
				foreach (ShieldStatue other in existingStatues)
				{
					if (other != this && other != null && navAgent != null)
					{
						if (Vector3.Distance(targetPosition, other.targetPosition) <= navAgent.radius * 2f)
						{
							int randAngle = Random.Range(0, 360);
							float rad = randAngle * ((float)System.Math.PI / 180f);
							Vector3 offset = new Vector3(Mathf.Sin(rad) * targetSearchRadius, 0f, Mathf.Cos(rad) * targetSearchRadius);
							Vector3 candidate = ((ballRb != null) ? ballRb.position : ballController.transform.position) + offset;
							Vector3 diff = candidate - base.transform.position;
							targetPosition = base.transform.position + diff.normalized * Mathf.Min(diff.magnitude, maxMoveDist);
							overlapsOther = true;
							break;
						}
					}
				}
			}

			if (!overlapsOther)
			{
				validFound = true;
			}
		}

		if (!validFound)
		{
			targetPosition = base.transform.position;
		}
	}

	private void OnDisable()
	{
		if (existingStatues != null)
		{
			existingStatues.Remove(this);
		}
		if (ballController != null)
		{
			ballController.OnShoot -= MoveTowardsPlayer;
		}
		if (Level.Instance != null)
		{
			Level.Instance.OnOutOfBounds -= BackToStart;
		}
	}

	private void BackToStart()
	{
		targetPosition = startPosition;
	}

	private void FixedUpdate()
	{
		if ((targetPosition - base.transform.position).magnitude > 0.1f && navAgent != null && !navAgent.hasPath)
		{
			navAgent.SetDestination(targetPosition);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.rigidbody != ballRb)
			return;

		ContactPoint[] contacts = collision.contacts;
		if (contacts != null && contacts.Length > 0 && contacts[0].thisCollider == vulnerableCollider)
		{
			if (collision.impulse.magnitude > minBreakForce)
			{
				base.gameObject.SetActive(false);
			}
		}
		else
		{
			DoKick(collision.rigidbody);
		}
	}

	private void DoKick(Rigidbody other)
	{
		if (other == null)
			return;

		other.velocity = Vector3.zero;
		other.AddForce(Vector3.up * upKickForce + base.transform.forward * forwardKickForce, ForceMode.Impulse);
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = debugColor;
		Gizmos.DrawWireSphere(targetPosition, 1f);
	}
}
