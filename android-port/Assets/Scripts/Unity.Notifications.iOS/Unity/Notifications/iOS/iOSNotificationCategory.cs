using System.Collections.Generic;

namespace Unity.Notifications.iOS
{
	public class iOSNotificationCategory
	{
		private List<iOSNotificationAction> m_Actions;

		private List<string> m_IntentIdentifiers;

		public string Id { get; }

		public iOSNotificationAction[] Actions => null;

		public string[] IntentIdentifiers => null;

		public string HiddenPreviewsBodyPlaceholder { get; }

		public string SummaryFormat { get; }

		public iOSNotificationCategoryOptions Options { get; }
	}
}
