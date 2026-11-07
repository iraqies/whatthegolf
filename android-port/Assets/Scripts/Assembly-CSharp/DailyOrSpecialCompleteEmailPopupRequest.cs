using System.Threading.Tasks;

public class DailyOrSpecialCompleteEmailPopupRequest : EmailPopupRequest
{
	private string _contentPackId;

	private bool _didComplete;

	protected override bool CanBeSnoozed => false;

	protected override void AddListeners()
	{
	}

	protected override void RemoveListeners()
	{
	}

	private void OnPackComplete(string contentPackId, bool didComplete)
	{
	}

	protected override bool IsRequestValid()
	{
		return false;
	}

	private bool IsCurrentCampaignDailyOrSpecial()
	{
		return false;
	}

	protected override Task<bool> ShowAndAwaitPopupInternal()
	{
		return null;
	}
}
