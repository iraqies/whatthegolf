using Core;
using UnityEngine;
using UnityEngine.AI;

public class RoguelikeEnemy : MonoBehaviour
{
	public Transform Target;

	public GolfBallController PlayerShooter;

	public float AlertDistance;

	public float StopDistance;

	public float StepSize = 1f;

	public ParticleSystem DeathSystem;

	private NavMeshAgent agent;

	private bool doMove;

	private Vector3 lastPosition;

	private RoguelikeShooter player;

	private void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		if (PlayerShooter != null)
		{
			player = PlayerShooter.gameObject.GetComponent<RoguelikeShooter>();
			PlayerShooter.OnShoot += PlayerShooter_OnShoot;
		}
		lastPosition = transform.position;
		if (agent != null)
			agent.stoppingDistance = StopDistance;
	}

	private void PlayerShooter_OnShoot(Vector3 obj)
	{
		doMove = true;
		lastPosition = transform.position;
	}

	private void Update()
	{
		if (Target == null || agent == null)
			return;
		float distToTarget = Vector3.Distance(transform.position, Target.position);
		if (distToTarget <= AlertDistance && doMove)
		{
			agent.SetDestination(Target.position);
			agent.isStopped = false;
			agent.stoppingDistance = StopDistance;
			if (Vector3.Distance(transform.position, lastPosition) >= StepSize)
			{
				agent.isStopped = true;
				doMove = false;
				if (Vector3.Distance(transform.position, Target.position) <= StopDistance && player != null)
				{
					player.TakeDamage();
				}
				Vector3 pos = transform.position;
				if (StepSize > 0f)
				{
					transform.position = new Vector3(Mathf.RoundToInt(pos.x / StepSize) * StepSize, pos.y, Mathf.RoundToInt(pos.z / StepSize) * StepSize);
				}
			}
		}
	}

	public void Die()
	{
		if (DeathSystem != null)
		{
			DeathSystem.transform.position = transform.position;
			DeathSystem.Emit(400);
			gameObject.SetActive(false);
		}
	}
}
