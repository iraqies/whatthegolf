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
		if (pinGoal != null)
		{
			flagAudio = pinGoal.GetComponentInChildren<FlagAudio>();
			pinGoal.AllowedLayers = ~0;
			collisionInfo = RigidbodyCollisionInfo.GetOrAdd(pinGoal.gameObject);
			if (collisionInfo != null)
			{
				collisionInfo.OnHitEnter += OnFlagCollision;
			}
			if (preplayCountdownTime >= 1)
			{
				countdownTimer = preplayCountdownTime;
				if (playerObjects != null)
				{
					for (int i = 0; i < playerObjects.Length; i++)
					{
						if (playerObjects[i] != null && playerObjects[i].TryGetComponent<GolfBallController>(out GolfBallController gbc))
						{
							gbc.TimedBlockShot(preplayCountdownTime);
						}
					}
				}
			}
		}
	}

	protected override void ChallengeUpdate()
	{
		if (countdownTimer <= 0f)
		{
			return;
		}
		int sec = Mathf.RoundToInt(countdownTimer);
		if (sec != wholeSecTimer)
		{
			if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			{
				LevelManager.Instance.InGameMenu.ShowFullScreenText(sec.ToString(), 1f);
			}
			wholeSecTimer = sec;
			if (stopwatchSFX != null)
			{
				if (sec >= 1)
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
		if (playerObjects != null)
		{
			for (int i = 0; i < playerObjects.Length; i++)
			{
				if (hitInfo.otherGameObject == playerObjects[i])
				{
					if (flagAudio != null)
					{
						flagAudio.GoodHit();
					}
					Complete();
					return;
				}
			}
		}
		if (enemyObjects != null)
		{
			for (int i = 0; i < enemyObjects.Length; i++)
			{
				if (hitInfo.otherGameObject == enemyObjects[i])
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
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}
}
