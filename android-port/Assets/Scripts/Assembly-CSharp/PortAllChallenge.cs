using System.Collections.Generic;
using Core;

public class PortAllChallenge : Challenge
{
	public bool passThroughOnceOnly;

	public bool allInOne;

	public List<SimplePortal> Portals;

	private GolfBallController golfBallController;

	private FlagAudio flagAudio;

	protected override void Activate()
	{
	}

	protected override void ChallengeUpdate()
	{
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}
}
