using System.Collections;
using Triband.Splines;
using UnityEngine;
using UnityEngine.AI;

public class GooseBehaviour : MonoBehaviour
{
	private enum GooseState
	{
		CHILL = 0,
		CHASE = 1,
		KICK = 2,
		LOST = 3,
		POKED = 4
	}

	private GooseState currentState;

	[SerializeField]
	private NavMeshAgent agent;

	[SerializeField]
	private Spline path;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private float yeetForce;

	[SerializeField]
	private float attackRange = 6f;

	private Transform chaseTarget;

	private Vector3 lastPlayerPos;

	private float baseSpeed;

	private Vector3 startingPos;

	private Quaternion startingRot;

	private void Start()
	{
		if (agent != null)
		{
			baseSpeed = agent.speed;
		}
		if (path == null)
		{
			startingPos = base.transform.position;
			startingRot = base.transform.rotation;
		}
	}

	private void Update()
	{
		switch (currentState)
		{
		case GooseState.CHILL:
			if (path != null)
			{
				FollowPath();
			}
			else
			{
				GoesBackToOriginPos();
			}
			break;
		case GooseState.CHASE:
			Chase();
			break;
		case GooseState.KICK:
		case GooseState.LOST:
			if (agent != null)
			{
				agent.speed = 0f;
			}
			break;
		case GooseState.POKED:
			break;
		}
	}

	public void FollowPath()
	{
		if (path == null || agent == null)
		{
			return;
		}
		SplinePoint closestPoint = path.GetClosestPoint(base.transform.position, 0.2f);
		float num = closestPoint.t + agent.speed / path.GetLength();
		if (num >= 1f)
		{
			num = agent.speed / path.GetLength() * 0.5f;
		}
		SplinePoint splinePoint = path.Evaluate(num, true);
		agent.destination = splinePoint.point;
		if (animator != null)
		{
			animator.SetFloat("Velocity", 1f);
		}
	}

	public void GoesBackToOriginPos()
	{
		if (agent != null)
		{
			agent.destination = startingPos;
			if (animator != null)
			{
				animator.SetFloat("Velocity", agent.velocity.sqrMagnitude * 0.02f);
			}
		}
		if (Vector3.Distance(startingPos, base.transform.position) < 2f)
		{
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, startingRot, Time.deltaTime * 10f);
		}
	}

	public void Chase()
	{
		if (chaseTarget != null)
		{
			if (agent != null)
			{
				agent.speed = baseSpeed * 2f;
				agent.destination = chaseTarget.position;
			}
			if (animator != null)
			{
				animator.SetFloat("Velocity", 10f);
			}
			if (Vector3.Distance(chaseTarget.position, base.transform.position) <= attackRange && currentState != GooseState.KICK)
			{
				currentState = GooseState.KICK;
				StartCoroutine(TryKickBall());
			}
		}
		if (lastPlayerPos != Vector3.zero && currentState != GooseState.KICK)
		{
			if (agent != null)
			{
				agent.destination = lastPlayerPos;
				if (animator != null)
				{
					animator.SetFloat("Velocity", agent.velocity.sqrMagnitude * 0.1f);
				}
			}
			if (agent != null && agent.velocity.sqrMagnitude < 0.1f && Vector3.Distance(lastPlayerPos, base.transform.position) <= attackRange && currentState != GooseState.LOST)
			{
				StartCoroutine(GetLost());
			}
		}
	}

	private IEnumerator GetLost()
	{
		if (agent != null)
		{
			agent.speed = baseSpeed;
		}
		currentState = GooseState.LOST;
		if (animator != null)
		{
			animator.SetTrigger("Lost");
		}
		yield return new WaitForSeconds(1.7f);
		if (currentState != GooseState.CHASE)
		{
			currentState = GooseState.CHILL;
		}
	}

	private IEnumerator TryKickBall()
	{
		if (animator != null)
		{
			animator.SetFloat("Velocity", 10f);
			animator.SetTrigger("Kick");
		}
		yield return new WaitForSeconds(0.1f);
		if (chaseTarget != null)
		{
			Rigidbody componentInChildren = chaseTarget.GetComponentInChildren<Rigidbody>();
			Vector3 normalized = (chaseTarget.position - base.transform.position).normalized;
			if (componentInChildren != null)
			{
				componentInChildren.AddForce((normalized + Vector3.up) * yeetForce, ForceMode.VelocityChange);
			}
			chaseTarget = null;
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
		currentState = GooseState.CHILL;
	}

	private void StopAfterKick()
	{
		if (agent != null)
		{
			agent.speed = 0f;
		}
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

	public void Poked(Transform target)
	{
		if (target != null)
		{
			if (agent != null)
			{
				agent.destination = target.position;
			}
			chaseTarget = target;
			currentState = GooseState.POKED;
			StartCoroutine(ChaseAfterPoked());
		}
	}

	private IEnumerator ChaseAfterPoked()
	{
		yield return new WaitForSeconds(0.5f);
		currentState = GooseState.CHASE;
	}

	public void LostTarget(Vector3 lastPos)
	{
		if (currentState != GooseState.KICK)
		{
			chaseTarget = null;
			lastPlayerPos = lastPos;
		}
	}
}
