using Core;
using UnityEngine;

public class LimitedShotsShooter : GolfBallShooterExperimental
{
	public int NumberOfShots;

	public float MinimumVelocityBeforeForfeit;

	private int shotsTaken;

	private float waitTime;

	private float belowSpeedTimer;

	private bool gameWon;

	protected override void Awake()
	{
	}

	private void InstanceOnOnGoal(Level.CompletedState s)
	{
	}

	private void GoalOnOnGoalProgress(int playerIndex, string s)
	{
	}

	private void InstanceOnReset()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	protected override void FixedUpdate()
	{
	}
}
