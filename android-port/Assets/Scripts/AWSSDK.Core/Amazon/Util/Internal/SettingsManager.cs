using System.Collections.Generic;
using Amazon.Runtime.Internal.Settings;

namespace Amazon.Util.Internal
{
	public class SettingsManager
	{
		public static bool IsAvailable => false;

		public string SettingsType { get; private set; }

		public SettingsManager(string settingsType)
		{
		}

		public string RegisterObject(Dictionary<string, string> properties)
		{
			return null;
		}

		public string RegisterObject(string uniqueKey, Dictionary<string, string> properties)
		{
			return null;
		}

		public bool TryGetObject(string uniqueKey, out Dictionary<string, string> properties)
		{
			properties = null;
			return false;
		}

		public bool TryGetObjectByProperty(string propertyName, string value, out string uniqueKey, out Dictionary<string, string> properties)
		{
			uniqueKey = null;
			properties = null;
			return false;
		}

		public List<string> ListUniqueKeys()
		{
			return null;
		}

		public List<string> SelectProperty(string propertyName)
		{
			return null;
		}

		public void UnregisterObject(string uniqueKey)
		{
		}

		private SettingsCollection GetSettings()
		{
			return null;
		}

		private void SaveSettings(SettingsCollection settings)
		{
		}

		private static bool TryGetObjectSettings(string propertyName, string value, SettingsCollection settings, out SettingsCollection.ObjectSettings objectSettings)
		{
			objectSettings = null;
			return false;
		}

		private static bool TryGetObjectSettings(string uniqueKey, SettingsCollection settings, out SettingsCollection.ObjectSettings objectSettings)
		{
			objectSettings = null;
			return false;
		}

		private static void EnsureAvailable()
		{
		}
	}
}
