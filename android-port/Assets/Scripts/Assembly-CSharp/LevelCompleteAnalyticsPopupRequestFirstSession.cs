public class LevelCompleteAnalyticsPopupRequestFirstSession : LevelCompleteAnalyticsPopupRequestBase
{
	protected override bool CanBeSnoozed => false;

	protected override ConsentRequestTypes RequestType => ConsentRequestTypes.Notifications;
}
