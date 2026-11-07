public abstract class AnalyticsConsentPopupRequest : ConsentPopupRequest
{
	protected override ConsentRequestTypes RequestType => ConsentRequestTypes.Notifications;

	protected override bool IsFeatureEnabled()
	{
		return false;
	}
}
