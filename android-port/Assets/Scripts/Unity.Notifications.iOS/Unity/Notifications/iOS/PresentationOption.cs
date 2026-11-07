using System;

namespace Unity.Notifications.iOS
{
	[Flags]
	public enum PresentationOption
	{
		None = 0,
		Badge = 1,
		Sound = 2,
		Alert = 4
	}
}
