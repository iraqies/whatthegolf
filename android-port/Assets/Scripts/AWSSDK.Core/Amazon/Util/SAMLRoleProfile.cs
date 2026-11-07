using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Settings;

namespace Amazon.Util
{
	[Obsolete]
	public class SAMLRoleProfile : ProfileSettingsBase
	{
		private object _synclock;

		private SAMLImmutableCredentials _session;

		public string RoleArn { get; internal set; }

		public string UserIdentity { get; internal set; }

		public bool UseDefaultUserIdentity => false;

		public string Region { get; private set; }

		public SAMLEndpointSettings EndpointSettings { get; internal set; }

		public SAMLImmutableCredentials GetCurrentSession()
		{
			return null;
		}

		public void PersistSession(SAMLImmutableCredentials credentials)
		{
		}

		private void UpdateProfileSessionData(SAMLImmutableCredentials credentials)
		{
		}

		public static bool CanCreateFrom(string profileName)
		{
			return false;
		}

		public static bool CanCreateFrom(SettingsCollection.ObjectSettings os)
		{
			return false;
		}

		public static SAMLRoleProfile LoadFrom(string profileName)
		{
			return null;
		}

		public static SAMLRoleProfile LoadFrom(SettingsCollection.ObjectSettings os)
		{
			return null;
		}

		public static void Validate(string profileName)
		{
		}

		private static void Validate(SettingsCollection.ObjectSettings os)
		{
		}

		public override string Persist()
		{
			return null;
		}

		private string Persist(string session)
		{
			return null;
		}

		public static string Persist(string profileName, string endpointSettingsName, string roleArn, string userIdentity, string session, string region)
		{
			return null;
		}

		private static SAMLImmutableCredentials LoadActiveSessionCredentials(string profileName)
		{
			return null;
		}

		private static void PersistActiveSessionCredentials(string profileName, string session)
		{
		}

		private SAMLRoleProfile(string profileName, SAMLEndpointSettings endpointSettings, string roleArn, string userIdentity, SAMLImmutableCredentials currentSession, string region)
		{
		}
	}
}
