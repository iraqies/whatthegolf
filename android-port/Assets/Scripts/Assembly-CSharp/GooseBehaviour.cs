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
	private float attackRange;

	private Transform chaseTarget;

	private Vector3 lastPlayerPos;

	private float baseSpeed;

	private Vector3 startingPos;

	private Quaternion startingRot;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void FollowPath()
	{
	}

	public void GoesBackToOriginPos()
	{
	}

	public void Chase()
	{
	}

	private IEnumerator GetLost()
	{
		return null;
	}

	private IEnumerator TryKickBall()
	{
		return null;
	}

	private void StopAfterKick()
	{
	}

	public void StartChasing(Transform target)
	{
	}

	public void UpdateChaseTarget(Transform target)
	{
	}

	public void Poked(Transform target)
	{
	}

	private IEnumerator ChaseAfterPoked()
	{
		return null;
	}

	public void LostTarget(Vector3 lastPos)
	{
	}
}
