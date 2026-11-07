namespace Unity.Notifications.iOS
{
	public struct iOSNotificationLocationTrigger : iOSNotificationTrigger
	{
		public iOSNotificationTriggerType Type => iOSNotificationTriggerType.TimeInterval;

		public double Latitude { get; }

		public double Longitude { get; }

		public float Radius { get; }

		public bool NotifyOnEntry { get; }

		public bool NotifyOnExit { get; }

		public bool Repeats { get; }
	}
}
