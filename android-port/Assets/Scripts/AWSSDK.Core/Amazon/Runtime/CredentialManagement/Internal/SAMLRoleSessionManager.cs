using Amazon.Util.Internal;

namespace Amazon.Runtime.CredentialManagement.Internal
{
	public class SAMLRoleSessionManager
	{
		private SettingsManager settingsManager;

		public static bool IsAvailable => false;

		public void Clear()
		{
		}

		public bool TryGetRoleSession(string roleSessionName, out SAMLImmutableCredentials credentials)
		{
			credentials = null;
			return false;
		}

		public void RegisterRoleSession(string roleSessionName, SAMLImmutableCredentials credentials)
		{
		}

		public void UnregisterRoleSession(string roleSessionName)
		{
		}
	}
}
