using Core;
using UnityEngine;
using UnityEngine.AI;

public class RoguelikeEnemy : MonoBehaviour
{
	public Transform Target;

	public GolfBallController PlayerShooter;

	public float AlertDistance;

	public float StopDistance;

	public float StepSize;

	public ParticleSystem DeathSystem;

	private NavMeshAgent agent;

	private bool doMove;

	private Vector3 lastPosition;

	private RoguelikeShooter player;

	private void Start()
	{
	}

	private void PlayerShooter_OnShoot(Vector3 obj)
	{
	}

	private void Update()
	{
	}

	public void Die()
	{
	}
}
