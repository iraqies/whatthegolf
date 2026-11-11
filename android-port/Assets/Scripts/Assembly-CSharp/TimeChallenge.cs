using Audio;
using Core;
using UnityEngine;

public class TimeChallenge : Challenge
{
	private enum TimeState
	{
		PrePlayCountdown = 0,
		CountingDown = 1
	}

	public int TimeToBeat;

	public int PreplayCountdownTime = 3;

	private float timer;

	public GolfBallController controller;

	private int lastSecond;

	private bool isActive;

	private TimeState currentState;

	private StopwatchSFX stopwatchSFX;

	public bool winOnTimeOut;

	private int currentTimeToBeat;

	protected override void Activate()
	{
		float extraPct = (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null)
			? PlatformSettings.Instance.GetCurrent().challengeTimeExtraPct
			: 0f;
		currentTimeToBeat = Mathf.CeilToInt((1f + extraPct) * TimeToBeat);

		if (controller == null)
		{
			controller = FindObjectOfType<GolfBallController>();
		}
		isActive = true;
		stopwatchSFX = GetComponentInChildren<StopwatchSFX>(true);

		if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(currentTimeToBeat, (StrokeCounter.CounterTypes)1, true, 0);
		}

		if (PreplayCountdownTime >= 1)
		{
			currentState = TimeState.PrePlayCountdown;
			if (controller != null)
			{
				controller.TimedBlockShot(PreplayCountdownTime + 1);
				controller.BlockShooting = true;
			}
		}
		else
		{
			currentState = TimeState.CountingDown;
			if (stopwatchSFX != null)
			{
				stopwatchSFX.StartStopwatch(currentTimeToBeat);
			}
		}
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		if (stopwatchSFX != null)
		{
			stopwatchSFX.Stop();
		}
		isActive = false;
		Complete();
	}

	public override void OnFail()
	{
		base.OnFail();
		if (stopwatchSFX != null)
		{
			stopwatchSFX.Stop();
		}
	}

	protected override void ChallengeUpdate()
	{
		if (!isActive)
		{
			return;
		}
		timer += Time.deltaTime;
		if (currentState == TimeState.PrePlayCountdown)
		{
			if (timer >= PreplayCountdownTime + 1)
			{
				timer = 0f;
				currentState = TimeState.CountingDown;
				UnityEvents.OnChallengeStart?.Invoke();
				lastSecond = 0;
				if (controller != null)
				{
					controller.BlockShooting = false;
				}
				if (stopwatchSFX != null)
				{
					stopwatchSFX.StartStopwatch(currentTimeToBeat);
					stopwatchSFX.PlayStartSFX();
				}
			}
			int sec = (timer == float.PositiveInfinity) ? 0 : (int)timer;
			if (sec != lastSecond)
			{
				int countVal = PreplayCountdownTime - lastSecond;
				if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
				{
					LevelManager.Instance.InGameMenu.ShowFullScreenText(countVal.ToString(), 1f);
				}
				if (stopwatchSFX != null)
				{
					stopwatchSFX.PlayCountdown();
				}
			}
		}
		else if (currentState == TimeState.CountingDown)
		{
			int sec = (timer == float.PositiveInfinity) ? 0 : (int)timer;
			if (sec != lastSecond && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			{
				LevelManager.Instance.InGameMenu.CountStroke(controller, lastSecond);
			}
			if (timer >= currentTimeToBeat)
			{
				if (winOnTimeOut)
				{
					Complete();
				}
				else
				{
					Fail();
				}
			}
		}
		lastSecond = (timer == float.PositiveInfinity) ? 0 : (int)timer;
	}

	public override string GetDescription()
	{
		float extraPct = (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null)
			? PlatformSettings.Instance.GetCurrent().challengeTimeExtraPct
			: 0f;
		float totalSec = Mathf.CeilToInt((1f + extraPct) * TimeToBeat);
		string key = string.IsNullOrEmpty(DescriptionLocalizationId) ? "ID_CHALLENGE_TIMECHALLENGE" : DescriptionLocalizationId;
		string fmt = Localization.Instance != null ? Localization.Instance.GetString(key) : "{0}s";
		return string.Format(fmt, totalSec);
	}

	public override string GetWinMessageID()
	{
		return string.IsNullOrEmpty(WinMessageLocalizationId) ? "ID_CHALLENGE_TIMECHALLENGE_COMPLETION" : WinMessageLocalizationId;
	}
}
