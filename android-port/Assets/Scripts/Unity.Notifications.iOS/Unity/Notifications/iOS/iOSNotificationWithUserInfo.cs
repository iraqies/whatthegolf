using System.Collections.Generic;

namespace Unity.Notifications.iOS
{
	internal struct iOSNotificationWithUserInfo
	{
		internal iOSNotificationData data;

		internal Dictionary<string, string> userInfo;

		internal List<iOSNotificationAttachment> attachments;
	}
}
