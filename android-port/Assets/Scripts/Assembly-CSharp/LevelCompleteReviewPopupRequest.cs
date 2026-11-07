using System.Threading.Tasks;

public class LevelCompleteReviewPopupRequest : ReviewConsentPopupRequest
{
	protected override bool CanBeSnoozed => false;

	protected override void AddListeners()
	{
	}

	protected override void RemoveListeners()
	{
	}

	protected override bool IsRequestValid()
	{
		return false;
	}

	protected override Task<bool> ShowAndAwaitPopupInternal()
	{
		return null;
	}
}
