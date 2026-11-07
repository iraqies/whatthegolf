public abstract class NotificationConsentPopupRequest : ConsentPopupRequest
{
	protected override ConsentRequestTypes RequestType => ConsentRequestTypes.Notifications;

	protected override bool IsFeatureEnabled()
	{
		return false;
	}
}
