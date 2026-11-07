using Core;

public class SurviveTimeChallenge : Challenge
{
	private enum TimeState
	{
		PrePlayCountdown = 0,
		CountingDown = 1
	}

	public int TimeToSurvive;

	public int PreplayCountdownTime;

	private float timer;

	public GolfBallController controller;

	private int lastSecond;

	private bool isActive;

	private TimeState currentState;

	protected override void Activate()
	{
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	public override string GetDescription()
	{
		return null;
	}

	protected override void ChallengeUpdate()
	{
	}
}
