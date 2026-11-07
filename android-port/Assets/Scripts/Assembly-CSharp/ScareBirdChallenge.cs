using Audio;
using Core;

public class ScareBirdChallenge : Challenge
{
	public bool GolfToFlagAfter;

	public float CustomScareTriggerRange;

	private BirdNPC[] scareBirds;

	private int scareCount;

	private GolfBallController controller;

	private TiltChallengeSFX SFX;

	protected override void Activate()
	{
	}

	private void OnBirdScared(BirdNPC bird)
	{
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
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
