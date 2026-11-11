using Core;
using UnityEngine;

public class SurviveTimeChallenge : Challenge
{
	private enum TimeState
	{
		PrePlayCountdown = 0,
		CountingDown = 1
	}

	public int TimeToSurvive;

	public int PreplayCountdownTime = 3;

	private float timer;

	public GolfBallController controller;

	private int lastSecond;

	private bool isActive;

	private TimeState currentState;

	protected override void Activate()
	{
		if (controller == null)
		{
			controller = Object.FindObjectOfType<GolfBallController>();
		}
		isActive = true;
		if (PreplayCountdownTime >= 1)
		{
			if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			{
				LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(PreplayCountdownTime, true, true, false);
			}
			currentState = TimeState.PrePlayCountdown;
			if (controller != null)
			{
				controller.TimedBlockShot(PreplayCountdownTime);
			}
		}
		else
		{
			if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			{
				LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(TimeToSurvive, true, true, false);
			}
			currentState = TimeState.CountingDown;
		}
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		isActive = false;
		Complete();
	}

	public override string GetDescription()
	{
		if (string.IsNullOrEmpty(DescriptionLocalizationID))
		{
			return Localization.Instance != null
				? string.Format(Localization.Instance.GetString("ID_CHALLENGE_SURVIVE_TIME"), TimeToSurvive)
				: string.Format("ID_CHALLENGE_SURVIVE_TIME", TimeToSurvive);
		}
		return Localization.Instance != null ? Localization.Instance.GetString(DescriptionLocalizationID) : DescriptionLocalizationID;
	}

	protected override void ChallengeUpdate()
	{
		if (!isActive)
		{
			return;
		}
		timer += Time.deltaTime;
		int curSec = (int)timer;
		if (curSec != lastSecond)
		{
			if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			{
				LevelManager.Instance.InGameMenu.CountStroke(controller, lastSecond);
			}
			lastSecond = curSec;
		}
		if (currentState == TimeState.PrePlayCountdown)
		{
			if (timer >= PreplayCountdownTime)
			{
				timer = -0.1f;
				if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
				{
					LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(TimeToSurvive, true, true, false);
				}
				currentState = TimeState.CountingDown;
				OnPrePlayCountdownDone?.Invoke();
			}
		}
		else if (currentState == TimeState.CountingDown)
		{
			if (timer >= TimeToSurvive)
			{
				Complete();
			}
		}
	}
}
