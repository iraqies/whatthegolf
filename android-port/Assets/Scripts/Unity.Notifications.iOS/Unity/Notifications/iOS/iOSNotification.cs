using System.Collections.Generic;

namespace Unity.Notifications.iOS
{
	public class iOSNotification
	{
		private iOSNotificationData data;

		private Dictionary<string, string> userInfo;

		public string Identifier => null;

		public string Title
		{
			set
			{
			}
		}

		public string Body
		{
			set
			{
			}
		}

		public bool ShowInForeground
		{
			set
			{
			}
		}

		public PresentationOption ForegroundPresentationOption
		{
			set
			{
			}
		}

		public float? SoundVolume { get; }

		public string Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<iOSNotificationAttachment> Attachments { get; set; }

		public iOSNotificationTrigger Trigger
		{
			set
			{
			}
		}

		private static string GenerateUniqueID()
		{
			return null;
		}

		public iOSNotification(string identifier)
		{
		}

		internal iOSNotification(iOSNotificationWithUserInfo data)
		{
		}

		internal iOSNotificationWithUserInfo GetDataForSending()
		{
			return default;
		}
	}
}
