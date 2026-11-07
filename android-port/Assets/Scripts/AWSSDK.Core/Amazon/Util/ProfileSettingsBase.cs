using System;
using Amazon.Runtime.Internal.Settings;

namespace Amazon.Util
{
	[Obsolete]
	public abstract class ProfileSettingsBase
	{
		public string Name { get; protected set; }

		public string UniqueId { get; protected set; }

		public abstract string Persist();

		protected static SettingsCollection.ObjectSettings LoadCredentialsProfile(string profileName)
		{
			return null;
		}
	}
}
