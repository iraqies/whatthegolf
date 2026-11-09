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
		string key = !string.IsNullOrEmpty(DescriptionLocalizationId) ? DescriptionLocalizationId : "ID_CHALLENGE_DESC_REACH_GOAL";
		return Localization.Instance != null ? Localization.Instance.GetString(key) : key;
	}

	public override string GetWinMessageID()
	{
		return !string.IsNullOrEmpty(WinMessageLocalizationId) ? WinMessageLocalizationId : "ID_WIN_MESSAGE_CHALLENGE";
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		if (CompleteAfterDelay)
		{
			StartCoroutine(pTween.To(delay, _ => { }).Then(Complete));
		}
		else
		{
			Complete();
		}
	}
}
