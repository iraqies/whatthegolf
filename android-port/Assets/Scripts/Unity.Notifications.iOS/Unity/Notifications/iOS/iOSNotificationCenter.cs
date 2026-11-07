using System.Runtime.CompilerServices;

namespace Unity.Notifications.iOS
{
	public class iOSNotificationCenter
	{
		public delegate void NotificationReceivedCallback(iOSNotification notification);

		private static bool s_Initialized;

		[CompilerGenerated]
		private static NotificationReceivedCallback s_OnNotificationReceived;

		[CompilerGenerated]
		private static NotificationReceivedCallback s_OnRemoteNotificationReceived;

		public static int ApplicationBadge
		{
			set
			{
			}
		}

		private static bool Initialize()
		{
			return false;
		}

		public static void ScheduleNotification(iOSNotification notification)
		{
		}

		public static iOSNotification GetLastRespondedNotification()
		{
			return null;
		}

		public static void RemoveDeliveredNotification(string identifier)
		{
		}

		public static void RemoveAllScheduledNotifications()
		{
		}

		public static void RemoveAllDeliveredNotifications()
		{
		}

		public static iOSNotificationSettings GetNotificationSettings()
		{
			return default;
		}

		internal static void OnReceivedRemoteNotification(iOSNotificationWithUserInfo data)
		{
		}

		internal static void OnSentNotification(iOSNotificationWithUserInfo data)
		{
		}
	}
}
