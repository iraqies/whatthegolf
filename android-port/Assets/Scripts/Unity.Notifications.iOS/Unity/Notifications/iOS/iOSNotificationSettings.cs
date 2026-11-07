namespace Unity.Notifications.iOS
{
	public struct iOSNotificationSettings
	{
		internal int authorizationStatus;

		internal int notificationCenterSetting;

		internal int lockScreenSetting;

		internal int carPlaySetting;

		internal int alertSetting;

		internal int badgeSetting;

		internal int soundSetting;

		internal int alertStyle;

		internal int showPreviewsSetting;

		public AuthorizationStatus AuthorizationStatus => AuthorizationStatus.NotDetermined;
	}
}
