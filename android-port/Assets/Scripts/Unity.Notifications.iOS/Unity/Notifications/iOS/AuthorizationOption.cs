using System;

namespace Unity.Notifications.iOS
{
	[Flags]
	public enum AuthorizationOption
	{
		Badge = 1,
		Sound = 2,
		Alert = 4,
		CarPlay = 8,
		CriticalAlert = 0x10,
		ProvidesAppNotificationSettings = 0x20,
		Provisional = 0x40
	}
}
