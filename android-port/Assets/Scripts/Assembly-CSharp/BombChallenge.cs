using System.Collections.Generic;

public class BombChallenge : Challenge
{
	private BombChallengeTarget[] _targets;

	private List<BombChallengeTarget> _bombedTargets;

	public int targetsToWin;

	protected override void Activate()
	{
	}

	private void OnBombed(BombChallengeTarget target)
	{
	}
}
