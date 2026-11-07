using System.Threading.Tasks;

public class WhatsNewPopupRequest : ConsentPopupRequest
{
	private WTGNotification? _notifForNewContent;

	protected override bool CanBeSnoozed => false;

	protected override ConsentRequestTypes RequestType => ConsentRequestTypes.Notifications;

	protected override void AddListeners()
	{
	}

	protected override void RemoveListeners()
	{
	}

	protected override bool IsFeatureEnabled()
	{
		return false;
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
