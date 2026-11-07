using System;

namespace Unity.Notifications.iOS
{
	[Flags]
	public enum iOSNotificationCategoryOptions
	{
		None = 0,
		CustomDismissAction = 1,
		AllowInCarPlay = 2,
		HiddenPreviewsShowTitle = 4,
		HiddenPreviewsShowSubtitle = 8
	}
}
