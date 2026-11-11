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
	private int preplayCountdownTime = 3;

	private RigidbodyCollisionInfo collisionInfo;

	private GolfBallController controller;

	private StopwatchSFX stopwatchSFX;

	private float countdownTimer;

	private int wholeSecTimer;

	private FlagAudio flagAudio;

	protected override void Activate()
	{
		if (pinGoal == null)
		{
			pinGoal = Object.FindObjectOfType<GolfCoursePinGoal>();
		}
		stopwatchSFX = GetComponentInChildren<StopwatchSFX>();
		if (!(pinGoal != null))
		{
			return;
		}
		flagAudio = pinGoal.GetComponentInChildren<FlagAudio>();
		pinGoal.RequiredBallsInGoal = int.MaxValue;
		collisionInfo = RigidbodyCollisionInfo.GetOrAdd(pinGoal.gameObject);
		collisionInfo.onCollision += OnFlagCollision;
		if (preplayCountdownTime < 1)
		{
			return;
		}
		countdownTimer = preplayCountdownTime;
		for (int i = 0; i < playerObjects.Length; i++)
		{
			if (playerObjects[i].TryGetComponent<GolfBallController>(out var component))
			{
				component.TimedBlockShot(preplayCountdownTime);
			}
		}
	}

	protected override void ChallengeUpdate()
	{
		if (!(countdownTimer > 0f))
		{
			return;
		}
		int num = Mathf.RoundToInt(countdownTimer);
		if (num != wholeSecTimer)
		{
			LevelManager.Instance.InGameMenu.ShowFullScreenText(num.ToString(), 1f);
			wholeSecTimer = num;
			if (stopwatchSFX != null)
			{
				if (num >= 1)
				{
					stopwatchSFX.PlayCountdown();
				}
				else
				{
					stopwatchSFX.PlayStartSFX();
				}
			}
		}
		countdownTimer -= Time.deltaTime;
	}

	private void OnFlagCollision(HitInfo hitInfo)
	{
		for (int i = 0; i < playerObjects.Length; i++)
		{
			if (hitInfo.otherHit == playerObjects[i])
			{
				if (flagAudio != null)
				{
					flagAudio.GoodHit();
				}
				Complete();
				return;
			}
		}
		for (int j = 0; j < enemyObjects.Length; j++)
		{
			if (hitInfo.otherHit == enemyObjects[j])
			{
				if (flagAudio != null)
				{
					flagAudio.BadHit();
				}
				Fail();
				return;
			}
		}
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}
}
