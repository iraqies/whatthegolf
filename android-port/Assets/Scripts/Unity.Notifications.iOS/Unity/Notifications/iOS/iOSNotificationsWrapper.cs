using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x200001C")]
	internal class iOSNotificationsWrapper : MonoBehaviour
	{
		[Token(Token = "0x200001D")]
		private delegate void AuthorizationRequestCallback(IntPtr request, iOSAuthorizationRequestData data);

		[Token(Token = "0x200001E")]
		private delegate void NotificationReceivedCallback(iOSNotificationData notificationData);

		[Token(Token = "0x200001F")]
		private delegate void ReceiveNSDictionaryKeyValueCallback(IntPtr dict, string key, string value);

		[Token(Token = "0x2000020")]
		private delegate void ReceiveUNNotificationAttachmentCallback(IntPtr array, string id, string url);

		[PreserveSig]
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2A448A4", Offset = "0x2A448A4", VA = "0x2A448A4")]
		private static extern void _RequestAuthorization(IntPtr request, int options, bool registerForRemote);

		[PreserveSig]
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2A448A8", Offset = "0x2A448A8", VA = "0x2A448A8")]
		private static extern void _ScheduleLocalNotification(iOSNotificationData data);

		[PreserveSig]
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2A44A20", Offset = "0x2A44A20", VA = "0x2A44A20")]
		private static extern void _SetNotificationReceivedDelegate(NotificationReceivedCallback callback);

		[PreserveSig]
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2A44A34", Offset = "0x2A44A34", VA = "0x2A44A34")]
		private static extern void _SetRemoteNotificationReceivedDelegate(NotificationReceivedCallback callback);

		[PreserveSig]
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2A44A48", Offset = "0x2A44A48", VA = "0x2A44A48")]
		private static extern void _SetAuthorizationRequestReceivedDelegate(AuthorizationRequestCallback callback);

		[PreserveSig]
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2A44A5C", Offset = "0x2A44A5C", VA = "0x2A44A5C")]
		private static extern iOSNotificationSettings _GetNotificationSettings();

		[PreserveSig]
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2A44A60", Offset = "0x2A44A60", VA = "0x2A44A60")]
		private static extern IntPtr _GetScheduledNotificationDataArray(out int count);

		[PreserveSig]
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2A44A64", Offset = "0x2A44A64", VA = "0x2A44A64")]
		private static extern IntPtr _GetDeliveredNotificationDataArray(out int count);

		[PreserveSig]
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2A43A6C", Offset = "0x2A43A6C", VA = "0x2A43A6C")]
		internal static extern void _RemoveAllScheduledNotifications();

		[PreserveSig]
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2A439E8", Offset = "0x2A439E8", VA = "0x2A439E8")]
		internal static extern void _RemoveDeliveredNotification(string identifier);

		[PreserveSig]
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2A44A68", Offset = "0x2A44A68", VA = "0x2A44A68")]
		private static extern void _SetApplicationBadge(int badge);

		[PreserveSig]
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2A44A6C", Offset = "0x2A44A6C", VA = "0x2A44A6C")]
		private static extern int _GetApplicationBadge();

		[PreserveSig]
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2A44A70", Offset = "0x2A44A70", VA = "0x2A44A70")]
		private static extern bool _GetAppOpenedUsingNotification();

		[PreserveSig]
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2A43ACC", Offset = "0x2A43ACC", VA = "0x2A43ACC")]
		internal static extern void _RemoveAllDeliveredNotifications();

		[PreserveSig]
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2A44A8C", Offset = "0x2A44A8C", VA = "0x2A44A8C")]
		private static extern IntPtr _GetLastNotificationData();

		[PreserveSig]
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2A44A90", Offset = "0x2A44A90", VA = "0x2A44A90")]
		private static extern string _GetLastRespondedNotificationAction();

		[PreserveSig]
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2A44AC4", Offset = "0x2A44AC4", VA = "0x2A44AC4")]
		private static extern string _GetLastRespondedNotificationUserText();

		[PreserveSig]
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2A44AF8", Offset = "0x2A44AF8", VA = "0x2A44AF8")]
		private static extern void _FreeUnmanagediOSNotificationDataArray(IntPtr ptr, int count);

		[PreserveSig]
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2A44AFC", Offset = "0x2A44AFC", VA = "0x2A44AFC")]
		internal static extern IntPtr _AddItemToNSDictionary(IntPtr dict, string key, string value);

		[PreserveSig]
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2A44B64", Offset = "0x2A44B64", VA = "0x2A44B64")]
		internal static extern IntPtr _AddAttachmentToNSArray(IntPtr atts, string id, string url, out IntPtr error);

		[PreserveSig]
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2A44BD4", Offset = "0x2A44BD4", VA = "0x2A44BD4")]
		private static extern void _ReadNSDictionary(IntPtr handle, IntPtr nsDict, ReceiveNSDictionaryKeyValueCallback callback);

		[PreserveSig]
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2A44C08", Offset = "0x2A44C08", VA = "0x2A44C08")]
		private static extern void _ReadAttachmentsNSArray(IntPtr handle, IntPtr nsArray, ReceiveUNNotificationAttachmentCallback callback);

		[PreserveSig]
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2A42D24", Offset = "0x2A42D24", VA = "0x2A42D24")]
		internal static extern IntPtr _CreateUNNotificationAction(string id, string title, int options);

		[PreserveSig]
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2A44C3C", Offset = "0x2A44C3C", VA = "0x2A44C3C")]
		private static extern void _ReleaseNSObject(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2A44C40", Offset = "0x2A44C40", VA = "0x2A44C40")]
		private static extern string _NSErrorToMessage(IntPtr error);

		[PreserveSig]
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2A44C74", Offset = "0x2A44C74", VA = "0x2A44C74")]
		private static extern IntPtr _AddActionToNSArray(IntPtr actions, IntPtr action, int capacity);

		[PreserveSig]
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2A44C78", Offset = "0x2A44C78", VA = "0x2A44C78")]
		private static extern IntPtr _CreateUNNotificationCategory(string id, string hiddenPreviewsBodyPlaceholder, string summaryFormat, int options, IntPtr actions, IntPtr intentIdentifiers);

		[PreserveSig]
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2A44D10", Offset = "0x2A44D10", VA = "0x2A44D10")]
		private static extern IntPtr _AddCategoryToCategorySet(IntPtr categorySet, IntPtr category);

		[PreserveSig]
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2A44D14", Offset = "0x2A44D14", VA = "0x2A44D14")]
		private static extern void _SetNotificationCategories(IntPtr categorySet);

		[PreserveSig]
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2A44D18", Offset = "0x2A44D18", VA = "0x2A44D18")]
		private static extern IntPtr _AddStringToNSArray(IntPtr array, string str, int capacity);

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2A41BF4", Offset = "0x2A41BF4", VA = "0x2A41BF4")]
		public static void RegisterAuthorizationRequestCallback()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2A44DCC", Offset = "0x2A44DCC", VA = "0x2A44DCC")]
		public static void RegisterOnReceivedRemoteNotificationCallback()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2A43328", Offset = "0x2A43328", VA = "0x2A43328")]
		public static void RegisterOnReceivedCallback()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2A44380", Offset = "0x2A44380", VA = "0x2A44380")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1B5328", Offset = "0x1B5328")]
		public static void AuthorizationRequestReceived(IntPtr request, iOSAuthorizationRequestData data)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2A4441C", Offset = "0x2A4441C", VA = "0x2A4441C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1B5390", Offset = "0x1B5390")]
		public static void RemoteNotificationReceived(iOSNotificationData data)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2A4456C", Offset = "0x2A4456C", VA = "0x2A4456C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1B53F8", Offset = "0x1B53F8")]
		public static void NotificationReceived(iOSNotificationData data)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2A44ED0", Offset = "0x2A44ED0", VA = "0x2A44ED0")]
		private static iOSNotificationWithUserInfo NotificationDataToDataWithUserInfo(iOSNotificationData data)
		{
			return default;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2A446BC", Offset = "0x2A446BC", VA = "0x2A446BC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1B5460", Offset = "0x1B5460")]
		private static void ReceiveNSDictionaryKeyValue(IntPtr dict, string key, string value)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2A447B0", Offset = "0x2A447B0", VA = "0x2A447B0")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1B54C8", Offset = "0x1B54C8")]
		private static void ReceiveUNNotificationAttachment(IntPtr array, string id, string url)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2A41CEC", Offset = "0x2A41CEC", VA = "0x2A41CEC")]
		public static void RequestAuthorization(IntPtr request, int options, bool registerRemote)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2A43AD4", Offset = "0x2A43AD4", VA = "0x2A43AD4")]
		public static iOSNotificationSettings GetNotificationSettings()
		{
			return default;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2A43538", Offset = "0x2A43538", VA = "0x2A43538")]
		public static void ScheduleLocalNotification(iOSNotificationWithUserInfo data)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2A45600", Offset = "0x2A45600", VA = "0x2A45600")]
		public static iOSNotificationWithUserInfo[] GetDeliveredNotificationData()
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2A458E4", Offset = "0x2A458E4", VA = "0x2A458E4")]
		public static string GetLastRespondedNotificationAction()
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2A45918", Offset = "0x2A45918", VA = "0x2A45918")]
		public static string GetLastRespondedNotificationUserText()
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2A4594C", Offset = "0x2A4594C", VA = "0x2A4594C")]
		public static iOSNotificationWithUserInfo[] GetScheduledNotificationData()
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2A4562C", Offset = "0x2A4562C", VA = "0x2A4562C")]
		private static iOSNotificationWithUserInfo[] MarshalAndFreeNotificationDataArray(IntPtr ptr, int count)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2A451F4", Offset = "0x2A451F4", VA = "0x2A451F4")]
		public static IntPtr CsDictionaryToObjC(Dictionary<string, string> userInfo)
		{
			return default;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2A453A8", Offset = "0x2A453A8", VA = "0x2A453A8")]
		public static IntPtr CsAttachmentsToObjc(List<iOSNotificationAttachment> attachments)
		{
			return default;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2A44F58", Offset = "0x2A44F58", VA = "0x2A44F58")]
		public static Dictionary<string, string> NSDictionaryToCs(IntPtr dict)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2A45090", Offset = "0x2A45090", VA = "0x2A45090")]
		public static List<iOSNotificationAttachment> AttachmentsNSArrayToCs(IntPtr array)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2A4328C", Offset = "0x2A4328C", VA = "0x2A4328C")]
		public static void SetApplicationBadge(int badge)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2A45A38", Offset = "0x2A45A38", VA = "0x2A45A38")]
		public static int GetApplicationBadge()
		{
			return default;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2A45A3C", Offset = "0x2A45A3C", VA = "0x2A45A3C")]
		public static bool GetAppOpenedUsingNotification()
		{
			return default;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2A436F4", Offset = "0x2A436F4", VA = "0x2A436F4")]
		public static iOSNotificationWithUserInfo? GetLastNotificationData()
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2A45A58", Offset = "0x2A45A58", VA = "0x2A45A58")]
		public static void SetNotificationCategories(IEnumerable<iOSNotificationCategory> categories)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2A46610", Offset = "0x2A46610", VA = "0x2A46610")]
		public iOSNotificationsWrapper()
		{
		}
	}
}
