using System;

namespace Unity.Notifications.iOS
{
	public struct iOSNotificationTimeIntervalTrigger : iOSNotificationTrigger
	{
		internal int timeInterval;

		public iOSNotificationTriggerType Type => iOSNotificationTriggerType.TimeInterval;

		public TimeSpan TimeInterval
		{
			set
			{
			}
		}

		public bool Repeats { get; set; }
	}
}
