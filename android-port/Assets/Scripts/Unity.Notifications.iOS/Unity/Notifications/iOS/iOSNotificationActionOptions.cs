using System;

namespace Unity.Notifications.iOS
{
	[Flags]
	public enum iOSNotificationActionOptions
	{
		None = 0,
		Required = 1,
		Destructive = 2,
		Foreground = 4
	}
}
