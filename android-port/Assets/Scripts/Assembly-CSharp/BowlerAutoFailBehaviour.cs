using System;
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
		if (bowlingShooters == null || bowlingShooters.Length == 0)
		{
			bowlingShooters = UnityEngine.Object.FindObjectsOfType<BowlingShooter>();
		}
		for (int i = 0; i < bowlingShooters.Length; i++)
		{
			if (bowlingShooters[i] != null)
			{
				BowlingShooter obj = bowlingShooters[i];
				obj.OnBallShot = (Action<Rigidbody>)Delegate.Combine(obj.OnBallShot, new Action<Rigidbody>(OnNewBall));
			}
		}
	}

	private void OnNewBall(Rigidbody obj)
	{
		if (activeBalls == null)
		{
			activeBalls = new List<Rigidbody>();
		}
		activeBalls.Add(obj);
	}

	private void FixedUpdate()
	{
	}
}
