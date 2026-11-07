using System.Globalization;

namespace PlayFab.Internal
{
	internal static class PlayFabUtil
	{
		private static string _localSettingsFileName;

		public static readonly string[] _defaultDateTimeFormats;

		public static DateTimeStyles DateTimeStyles;

		static PlayFabUtil()
		{
		}
	}
}
