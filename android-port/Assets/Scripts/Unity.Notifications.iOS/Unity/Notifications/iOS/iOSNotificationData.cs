using System;

namespace Unity.Notifications.iOS
{
	internal struct iOSNotificationData
	{
		public string identifier;

		public string title;

		public string body;

		public int badge;

		public string subtitle;

		public string categoryIdentifier;

		public string threadIdentifier;

		public int soundType;

		public float soundVolume;

		public string soundName;

		public IntPtr userInfo;

		public IntPtr attachments;

		public int triggerType;

		public TriggerData trigger;
	}
}
