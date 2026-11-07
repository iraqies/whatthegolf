using System.Collections.Generic;
using UnityEngine;

public class BossPlayerFollowNodesTowardsGoal : MonoBehaviour
{
	public BossIslands IslandsCreator;

	public Rigidbody PlayerRigid;

	[SerializeField]
	private List<Transform> nodes;

	public AnimationCurve MoveSpeed;

	public float RotateSpeed;

	public float MoveSpeedIncreaseSpeed;

	public Transform Goal;

	public float DeathTimer;

	public float minDistance;

	private float moveTimer;

	private void Start()
	{
	}

	private void NewIslandSpawned(BossIslandPart bossIslandPart)
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}
}
