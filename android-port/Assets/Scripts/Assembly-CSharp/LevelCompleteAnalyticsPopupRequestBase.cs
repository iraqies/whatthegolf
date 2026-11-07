using System.Threading.Tasks;

public abstract class LevelCompleteAnalyticsPopupRequestBase : AnalyticsConsentPopupRequest
{
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
