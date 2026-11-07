using Audio;
using Core;
using GolfCourse;
using UnityEngine;

public class SimpleRaceChallenge : Challenge
{
	[SerializeField]
	private GameObject[] playerObjects;

	[SerializeField]
	private GameObject[] enemyObjects;

	[SerializeField]
	private GolfCoursePinGoal pinGoal;

	[SerializeField]
	private int preplayCountdownTime;

	private RigidbodyCollisionInfo collisionInfo;

	private GolfBallController controller;

	private StopwatchSFX stopwatchSFX;

	private float countdownTimer;

	private int wholeSecTimer;

	private FlagAudio flagAudio;

	protected override void Activate()
	{
	}

	protected override void ChallengeUpdate()
	{
	}

	private void OnFlagCollision(HitInfo hitInfo)
	{
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}
}
