using System.Collections.Generic;

namespace Amazon.Runtime.Internal.Settings
{
	public class InMemoryPersistenceManager : IPersistenceManager
	{
		private readonly Dictionary<string, SettingsCollection> _settingsDictionary;

		public SettingsCollection GetSettings(string type)
		{
			return null;
		}

		public void SaveSettings(string type, SettingsCollection settings)
		{
		}
	}
}
