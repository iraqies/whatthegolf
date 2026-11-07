using Core;
using UnityEngine;

public class RunnerGolfShooter : GolfBallShooterExperimental
{
	public float ForwardSpeed;

	public float SpinSpeed;

	public float JumpSpeed;

	public float MoveAngleThreshold;

	public float MoveLaneSpeed;

	public float LaneWidth;

	public int NumberOfLanes;

	public int StartLane;

	public AudioClip CoinCollectClip;

	private int currentLane;

	private int targetLane;

	private Vector3 startPos;

	private bool canJump;

	protected override void Awake()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private void OnCollisionStay(Collision col)
	{
	}

	protected new void FixedUpdate()
	{
	}

	protected virtual void Jump()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public override void OnReset()
	{
	}
}
