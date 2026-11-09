using Core;
using UnityEngine;

public class LimitedShotsShooter : GolfBallShooterExperimental
{
	public int NumberOfShots = 1;

	public float MinimumVelocityBeforeForfeit = 1f;

	private int shotsTaken;

	private float waitTime;

	private float belowSpeedTimer;

	private bool gameWon;

	protected override void Awake()
	{
		base.Awake();
		if (Level.HasInstance && Level.Instance != null)
		{
			Level.Instance.OnComplete += InstanceOnOnGoal;
			if (Level.Instance.Goal != null)
				Level.Instance.Goal.OnGoalProgress += GoalOnOnGoalProgress;
			Level.Instance.OnReset += InstanceOnReset;
		}
	}

	private void InstanceOnOnGoal(Level.CompletedState s)
	{
		gameWon = true;
	}

	private void GoalOnOnGoalProgress(int playerIndex, string s)
	{
		if (GolfBallController != null && playerIndex == GolfBallController.PlayerIndex)
			gameWon = true;
	}

	private void InstanceOnReset()
	{
		if (GolfBallController != null)
			GolfBallController.enabled = true;
		shotsTaken = 0;
		waitTime = 1f;
		belowSpeedTimer = 0f;
		gameWon = false;
	}

	public override void OnShoot(Vector3 boost)
	{
		int maxShots = NumberOfShots > 0 ? NumberOfShots : 1;
		if (shotsTaken < maxShots)
		{
			shotsTaken++;
			waitTime = 0.1f;
			if (shotsTaken >= maxShots && GolfBallController != null)
			{
				GolfBallController.enabled = false;
				if (GolfBallController.shootArrow != null)
					GolfBallController.shootArrow.Hide();
			}
			base.OnShoot(boost);
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (gameWon)
			return;
		waitTime -= Time.deltaTime;
		if (waitTime > 0f)
			return;

		int maxShots = NumberOfShots > 0 ? NumberOfShots : 1;
		if (shotsTaken < maxShots || rigidbodyC == null)
			return;

		if (rigidbodyC.velocity.magnitude < MinimumVelocityBeforeForfeit)
		{
			belowSpeedTimer += Time.deltaTime;
			if (belowSpeedTimer > 1f)
			{
				belowSpeedTimer = 0f;
				shotsTaken = 0;
				if (GolfBallController != null)
				{
					GolfBallController.enabled = true;
					GolfBallController.OutOfBounds(GolfBallController.ShowTransitionOnOutOfBounds ? "OutOfBounds" : "OutOfBoundsReload", 0f);
				}
			}
		}
	}
}
