using System.Collections.Generic;

namespace Amazon.Util.Internal
{
	public class NamedSettingsManager
	{
		private SettingsManager settingsManager;

		public static bool IsAvailable => false;

		public NamedSettingsManager(string settingsType)
		{
		}

		public string RegisterObject(string displayName, Dictionary<string, string> properties)
		{
			return null;
		}

		public bool TryGetObject(string displayName, out Dictionary<string, string> properties)
		{
			properties = null;
			return false;
		}

		public bool TryGetObject(string displayName, out string uniqueKey, out Dictionary<string, string> properties)
		{
			uniqueKey = null;
			properties = null;
			return false;
		}

		public void UnregisterObject(string displayName)
		{
		}

		public void RenameObject(string oldDisplayName, string newDisplayName, bool force)
		{
		}

		public void CopyObject(string fromDisplayName, string toDisplayName, bool force)
		{
		}

		public List<string> ListObjectNames()
		{
			return null;
		}
	}
}
