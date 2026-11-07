using System.Collections.Generic;

namespace PlayFab
{
	public class PlayFabApiSettings
	{
		private string _ProductionEnvironmentUrl;

		public readonly Dictionary<string, string> _requestGetParams;

		private string AdvertisingIdType;

		private string AdvertisingIdValue;

		private bool DisableAdvertising;

		private bool DisableDeviceInfo;

		public virtual Dictionary<string, string> RequestGetParams => null;

		public virtual string ProductionEnvironmentUrl => null;

		public virtual string TitleId { get; }

		internal virtual string VerticalName { get; }

		public virtual bool DisableFocusTimeCollection { get; }

		public virtual string GetFullUrl(string apiCall, Dictionary<string, string> getParams)
		{
			return null;
		}
	}
}
