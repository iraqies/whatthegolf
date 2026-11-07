using System.Collections.Generic;
using Core;
using UnityEngine;

public class InsideQueueManager : MonoBehaviour
{
	public List<Rigidbody> QueueMembers;

	public Vector3 QueueDirection;

	public float StopInterval;

	public float StopDuration;

	public float MoveForce;

	public float StartDelay;

	public float JumpForce;

	public float AlertRange;

	public float KillDistance;

	public BoxCollider ActivityCollider;

	public Transform QueueTarget;

	public Transform Player;

	public InsideObserver Observer;

	public List<SpiderLegs> Spiders;

	public float SpiderMoveSpeed;

	public GolfBallController PlayerController;

	public Transform StopFollowPoint;

	private float stopTimer;

	private float startDelayTimer;

	private float alertTime;

	private void Start()
	{
	}

	private void PlayerOnShoot(Vector3 vector3)
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}
}
