using System.Threading.Tasks;

public class StartupNotificationsPopupRequest : NotificationConsentPopupRequest
{
	private string title;

	private string description;

	protected override bool CanBeSnoozed => false;

	protected override ConsentRequestTypes RequestType => ConsentRequestTypes.Notifications;

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
