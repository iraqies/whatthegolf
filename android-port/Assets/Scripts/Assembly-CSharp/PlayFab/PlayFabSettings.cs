using System.Collections.Generic;

namespace PlayFab
{
	public static class PlayFabSettings
	{
		private static PlayFabSharedSettings _playFabShared;

		internal static readonly PlayFabApiSettings staticSettings;

		internal static readonly PlayFabAuthenticationContext staticPlayer;

		private static PlayFabSharedSettings PlayFabSharedPrivate => null;

		public static string DeviceUniqueIdentifier => null;

		public static string TitleId => null;

		public static bool DisableFocusTimeCollection => false;

		public static string LoggerHost => null;

		public static bool EnableRealTimeLogging => false;

		static PlayFabSettings()
		{
		}

		private static PlayFabSharedSettings GetSharedSettingsObjectPrivate()
		{
			return null;
		}

		public static string GetFullUrl(string apiCall, Dictionary<string, string> getParams, PlayFabApiSettings apiSettings = null)
		{
			return null;
		}
	}
}
