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
		if (agent != null)
		{
			baseSpeed = agent.speed;
		}
		startingPos = base.transform.position;
		startingRot = base.transform.rotation;
	}

	private void Update()
	{
		if (chaseTarget != null && agent != null)
		{
			agent.SetDestination(chaseTarget.position);
			if (Vector3.Distance(chaseTarget.position, base.transform.position) <= attackRange && currentState != GooseState.KICK)
			{
				currentState = GooseState.KICK;
				StartCoroutine(TryKickBall());
			}
		}
	}

	public void Chase()
	{
		if ((bool)chaseTarget && agent != null)
		{
			agent.speed = baseSpeed + baseSpeed;
			agent.destination = chaseTarget.position;
			if (Vector3.Distance(chaseTarget.position, base.transform.position) <= attackRange && currentState != GooseState.KICK)
			{
				currentState = GooseState.KICK;
				OnHit?.Invoke();
			}
		}
	}

	private IEnumerator TryKickBall()
	{
		OnHit?.Invoke();
		yield return new WaitForSeconds(0.1f);
		if (chaseTarget != null)
		{
			Rigidbody componentInChildren = chaseTarget.GetComponentInChildren<Rigidbody>();
			if (componentInChildren != null)
			{
				Vector3 normalized = (chaseTarget.position - base.transform.position).normalized;
				componentInChildren.AddForce((normalized + Vector3.up) * yeetForce, ForceMode.VelocityChange);
			}
			if (agent != null)
			{
				agent.speed = 0f;
			}
		}
		yield return new WaitForSeconds(1f);
		if (agent != null)
		{
			agent.speed = baseSpeed;
		}
		currentState = GooseState.CHASE;
	}

	public void StartChasing(Transform target)
	{
		if (currentState != GooseState.KICK)
		{
			chaseTarget = target;
			if (target != null)
			{
				lastPlayerPos = target.position;
			}
			currentState = GooseState.CHASE;
		}
	}

	public void UpdateChaseTarget(Transform target)
	{
		if (currentState != GooseState.KICK)
		{
			chaseTarget = target;
			if (target != null)
			{
				lastPlayerPos = target.position;
			}
		}
	}

	public AmongUsFollowAgent()
	{
		attackRange = 6f;
	}
}
