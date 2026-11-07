public class CalculateCompletionPercentageCommand
{
	private readonly ECampaignType _campaignType;

	private readonly int? _saveSlot;

	private readonly bool _includeChallenges;

	public CalculateCompletionPercentageCommand(ECampaignType campaignType, int? saveSlot = null, bool includeChallenges = true)
	{
	}

	public int Execute()
	{
		return 0;
	}
}
