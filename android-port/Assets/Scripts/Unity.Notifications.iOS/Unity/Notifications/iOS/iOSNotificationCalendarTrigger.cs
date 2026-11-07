using System;

namespace Unity.Notifications.iOS
{
	public struct iOSNotificationCalendarTrigger : iOSNotificationTrigger
	{
		public iOSNotificationTriggerType Type => iOSNotificationTriggerType.TimeInterval;

		public int? Year { get; set; }

		public int? Month { get; set; }

		public int? Day { get; set; }

		public int? Hour { get; set; }

		public int? Minute { get; set; }

		public int? Second { get; set; }

		public bool UtcTime { get; set; }

		public bool Repeats { get; set; }

		public iOSNotificationCalendarTrigger ToUtc()
		{
			return default;
		}

		internal DateTime AssignDateTimeComponents(DateTime dt)
		{
			return default;
		}

		internal void AssignNonEmptyComponents(DateTime dt)
		{
		}
	}
}
