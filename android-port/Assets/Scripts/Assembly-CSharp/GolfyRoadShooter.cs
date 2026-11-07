using Core;
using UnityEngine;

public class GolfyRoadShooter : RunnerGolfShooter
{
	private bool moveForward;

	private Vector3 startMovePos;

	private GolfBallController controller;

	protected override void Awake()
	{
	}

	protected override void Jump()
	{
	}

	protected new void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
