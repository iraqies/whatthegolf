using System.Collections.Generic;
using UnityEngine;

public class BowlerAutoFailBehaviour : AutoFailBase
{
	public float velocityThreshold;

	public BowlingShooter[] bowlingShooters;

	public bool CheckDistance;

	public Transform[] DistanceTargets;

	public float MinDistance;

	private List<Rigidbody> activeBalls;

	private void Awake()
	{
	}

	private void OnNewBall(Rigidbody obj)
	{
	}

	private void FixedUpdate()
	{
	}
}
