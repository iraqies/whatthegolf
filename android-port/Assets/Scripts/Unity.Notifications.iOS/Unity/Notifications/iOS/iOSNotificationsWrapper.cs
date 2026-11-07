using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Unity.Notifications.iOS
{
	internal class iOSNotificationsWrapper : MonoBehaviour
	{
		private delegate void AuthorizationRequestCallback(IntPtr request, iOSAuthorizationRequestData data);

		private delegate void NotificationReceivedCallback(iOSNotificationData notificationData);

		private delegate void ReceiveNSDictionaryKeyValueCallback(IntPtr dict, string key, string value);

		private delegate void ReceiveUNNotificationAttachmentCallback(IntPtr array, string id, string url);

		[PreserveSig]
		private static extern void _RequestAuthorization(IntPtr request, int options, bool registerForRemote);

		[PreserveSig]
		private static extern void _ScheduleLocalNotification(iOSNotificationData data);

		[PreserveSig]
		private static extern void _SetNotificationReceivedDelegate(NotificationReceivedCallback callback);

		[PreserveSig]
		private static extern void _SetRemoteNotificationReceivedDelegate(NotificationReceivedCallback callback);

		[PreserveSig]
		private static extern void _SetAuthorizationRequestReceivedDelegate(AuthorizationRequestCallback callback);

		[PreserveSig]
		private static extern iOSNotificationSettings _GetNotificationSettings();

		[PreserveSig]
		private static extern IntPtr _GetScheduledNotificationDataArray(out int count);

		[PreserveSig]
		private static extern IntPtr _GetDeliveredNotificationDataArray(out int count);

		[PreserveSig]
		internal static extern void _RemoveAllScheduledNotifications();

		[PreserveSig]
		internal static extern void _RemoveDeliveredNotification(string identifier);

		[PreserveSig]
		private static extern void _SetApplicationBadge(int badge);

		[PreserveSig]
		private static extern int _GetApplicationBadge();

		[PreserveSig]
		private static extern bool _GetAppOpenedUsingNotification();

		[PreserveSig]
		internal static extern void _RemoveAllDeliveredNotifications();

		[PreserveSig]
		private static extern IntPtr _GetLastNotificationData();

		[PreserveSig]
		private static extern string _GetLastRespondedNotificationAction();

		[PreserveSig]
		private static extern string _GetLastRespondedNotificationUserText();

		[PreserveSig]
		private static extern void _FreeUnmanagediOSNotificationDataArray(IntPtr ptr, int count);

		[PreserveSig]
		internal static extern IntPtr _AddItemToNSDictionary(IntPtr dict, string key, string value);

		[PreserveSig]
		internal static extern IntPtr _AddAttachmentToNSArray(IntPtr atts, string id, string url, out IntPtr error);

		[PreserveSig]
		private static extern void _ReadNSDictionary(IntPtr handle, IntPtr nsDict, ReceiveNSDictionaryKeyValueCallback callback);

		[PreserveSig]
		private static extern void _ReadAttachmentsNSArray(IntPtr handle, IntPtr nsArray, ReceiveUNNotificationAttachmentCallback callback);

		[PreserveSig]
		internal static extern IntPtr _CreateUNNotificationAction(string id, string title, int options);

		[PreserveSig]
		private static extern void _ReleaseNSObject(IntPtr obj);

		[PreserveSig]
		private static extern string _NSErrorToMessage(IntPtr error);

		[PreserveSig]
		private static extern IntPtr _AddActionToNSArray(IntPtr actions, IntPtr action, int capacity);

		[PreserveSig]
		private static extern IntPtr _CreateUNNotificationCategory(string id, string hiddenPreviewsBodyPlaceholder, string summaryFormat, int options, IntPtr actions, IntPtr intentIdentifiers);

		[PreserveSig]
		private static extern IntPtr _AddCategoryToCategorySet(IntPtr categorySet, IntPtr category);

		[PreserveSig]
		private static extern void _SetNotificationCategories(IntPtr categorySet);

		[PreserveSig]
		private static extern IntPtr _AddStringToNSArray(IntPtr array, string str, int capacity);

		public static void RegisterAuthorizationRequestCallback()
		{
		}

		public static void RegisterOnReceivedRemoteNotificationCallback()
		{
		}

		public static void RegisterOnReceivedCallback()
		{
		}

		public static void AuthorizationRequestReceived(IntPtr request, iOSAuthorizationRequestData data)
		{
		}

		public static void RemoteNotificationReceived(iOSNotificationData data)
		{
		}

		public static void NotificationReceived(iOSNotificationData data)
		{
		}

		private static iOSNotificationWithUserInfo NotificationDataToDataWithUserInfo(iOSNotificationData data)
		{
			return default;
		}

		private static void ReceiveNSDictionaryKeyValue(IntPtr dict, string key, string value)
		{
		}

		private static void ReceiveUNNotificationAttachment(IntPtr array, string id, string url)
		{
		}

		public static void RequestAuthorization(IntPtr request, int options, bool registerRemote)
		{
		}

		public static iOSNotificationSettings GetNotificationSettings()
		{
			return default;
		}

		public static void ScheduleLocalNotification(iOSNotificationWithUserInfo data)
		{
		}

		public static iOSNotificationWithUserInfo[] GetDeliveredNotificationData()
		{
			return null;
		}

		public static string GetLastRespondedNotificationAction()
		{
			return null;
		}

		public static string GetLastRespondedNotificationUserText()
		{
			return null;
		}

		public static iOSNotificationWithUserInfo[] GetScheduledNotificationData()
		{
			return null;
		}

		private static iOSNotificationWithUserInfo[] MarshalAndFreeNotificationDataArray(IntPtr ptr, int count)
		{
			return null;
		}

		public static IntPtr CsDictionaryToObjC(Dictionary<string, string> userInfo)
		{
			return (IntPtr)0;
		}

		public static IntPtr CsAttachmentsToObjc(List<iOSNotificationAttachment> attachments)
		{
			return (IntPtr)0;
		}

		public static Dictionary<string, string> NSDictionaryToCs(IntPtr dict)
		{
			return null;
		}

		public static List<iOSNotificationAttachment> AttachmentsNSArrayToCs(IntPtr array)
		{
			return null;
		}

		public static void SetApplicationBadge(int badge)
		{
		}

		public static int GetApplicationBadge()
		{
			return 0;
		}

		public static bool GetAppOpenedUsingNotification()
		{
			return false;
		}

		public static iOSNotificationWithUserInfo? GetLastNotificationData()
		{
			return null;
		}

		public static void SetNotificationCategories(IEnumerable<iOSNotificationCategory> categories)
		{
		}
	}
}
