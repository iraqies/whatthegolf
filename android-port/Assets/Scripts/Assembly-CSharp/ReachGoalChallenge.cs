using Core;

public class ReachGoalChallenge : Challenge
{
	public bool CompleteAfterDelay;

	public float delay;

	protected override void Activate()
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

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}
}
