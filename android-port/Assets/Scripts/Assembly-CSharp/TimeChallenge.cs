using Audio;
using Core;

public class TimeChallenge : Challenge
{
	private enum TimeState
	{
		PrePlayCountdown = 0,
		CountingDown = 1
	}

	public int TimeToBeat;

	public int PreplayCountdownTime;

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
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	public override void OnFail()
	{
	}

	protected override void ChallengeUpdate()
	{
	}

	public override string GetDescription()
	{
		return null;
	}

	public override string GetWinMessageID()
	{
		return null;
	}
}
