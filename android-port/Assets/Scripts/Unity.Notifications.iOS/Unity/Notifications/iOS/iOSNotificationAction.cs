using System;

namespace Unity.Notifications.iOS
{
	public class iOSNotificationAction
	{
		public string Id { get; }

		public string Title { get; }

		public iOSNotificationActionOptions Options { get; }

		internal virtual IntPtr CreateUNNotificationAction()
		{
			return (IntPtr)0;
		}
	}
}
