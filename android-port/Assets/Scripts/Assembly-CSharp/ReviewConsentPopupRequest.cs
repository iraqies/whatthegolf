public abstract class ReviewConsentPopupRequest : ConsentPopupRequest
{
	protected override ConsentRequestTypes RequestType => ConsentRequestTypes.Notifications;

	protected override bool IsFeatureEnabled()
	{
		return false;
	}
}
