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
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(PreplayCountdownTime, StrokeCounter.CounterTypes.CardsDisappearing, useExternalCountActivator: true);
			currentState = TimeState.PrePlayCountdown;
			controller.TimedBlockShot(PreplayCountdownTime);
		}
		else
		{
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(TimeToSurvive, StrokeCounter.CounterTypes.CardsDisappearing, useExternalCountActivator: true);
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
		if (string.IsNullOrEmpty(DescriptionLocalizationId))
		{
			return string.Format(Localization.Instance.GetString("ID_CHALLENGE_SURVIVE_TIME"), TimeToSurvive);
		}
		return Localization.Instance.GetString(DescriptionLocalizationId);
	}

	protected override void ChallengeUpdate()
	{
		if (!isActive)
		{
			return;
		}
		timer += Time.deltaTime;
		if ((int)timer != lastSecond)
		{
			LevelManager.Instance.InGameMenu.CountStroke(controller, lastSecond);
			lastSecond = (int)timer;
		}
		if (currentState == TimeState.PrePlayCountdown)
		{
			if (timer >= (float)PreplayCountdownTime)
			{
				timer = -0.1f;
				LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(TimeToSurvive, StrokeCounter.CounterTypes.CardsDisappearing, useExternalCountActivator: true);
				currentState = TimeState.CountingDown;
				UnityEvents.OnChallengeStart?.Invoke();
			}
		}
		else if (currentState == TimeState.CountingDown && timer >= (float)TimeToSurvive)
		{
			Complete();
		}
	}
}
