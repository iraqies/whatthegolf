using System.Collections.Generic;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Settings
{
	public class PersistenceManager : IPersistenceManager
	{
		private static readonly HashSet<string> ENCRYPTEDKEYS;

		private static readonly Logger _logger;

		private readonly Dictionary<string, SettingsWatcher> _watchers;

		private static string SettingsStoreFolder;

		public static IPersistenceManager Instance { get; set; }

		static PersistenceManager()
		{
		}

		public SettingsCollection GetSettings(string type)
		{
			return null;
		}

		public void SaveSettings(string type, SettingsCollection settings)
		{
		}

		public string GetSetting(string key)
		{
			return null;
		}

		public void SetSetting(string key, string value)
		{
		}

		public static string GetSettingsStoreFolder()
		{
			return null;
		}

		public SettingsWatcher Watch(string type)
		{
			return null;
		}

		private void enableWatcher(string type)
		{
		}

		private void disableWatcher(string type)
		{
		}

		internal static bool IsEncrypted(string key)
		{
			return false;
		}

		private void saveSettingsType(string type, SettingsCollection settings)
		{
		}

		private SettingsCollection loadSettingsType(string type)
		{
			return null;
		}

		private static void DecryptAnyEncryptedValues(Dictionary<string, Dictionary<string, object>> settings)
		{
		}

		private static string getFileFromType(string type)
		{
			return null;
		}
	}
}
