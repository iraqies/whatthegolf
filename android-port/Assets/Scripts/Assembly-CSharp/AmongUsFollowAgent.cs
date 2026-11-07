using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class AmongUsFollowAgent : MonoBehaviour
{
	private enum GooseState
	{
		CHASE = 0,
		KICK = 1
	}

	private GooseState currentState;

	[SerializeField]
	private NavMeshAgent agent;

	[SerializeField]
	private float yeetForce;

	[SerializeField]
	private float attackRange;

	public Transform chaseTarget;

	private Vector3 lastPlayerPos;

	private float baseSpeed;

	private Vector3 startingPos;

	private Quaternion startingRot;

	public UnityEvent OnHit;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Chase()
	{
	}

	private IEnumerator TryKickBall()
	{
		return null;
	}

	public void StartChasing(Transform target)
	{
	}

	public void UpdateChaseTarget(Transform target)
	{
	}
}
