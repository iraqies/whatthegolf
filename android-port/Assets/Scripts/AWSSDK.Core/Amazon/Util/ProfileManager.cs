using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Settings;

namespace Amazon.Util
{
	[Obsolete]
	public static class ProfileManager
	{
		public const string AWSCredentialsProfileType = "AWS";

		public const string SAMLRoleProfileType = "SAML";

		public static bool IsAvailable => false;

		public static void RegisterProfile(string profileName, string accessKeyId, string secretKey)
		{
		}

		public static void RegisterSAMLRoleProfile(string profileName, string endpointName, string roleArn, string userIdentity)
		{
		}

		public static void RegisterSAMLRoleProfile(string profileName, string endpointName, string roleArn, string userIdentity, string stsRegion)
		{
		}

		public static string RegisterSAMLEndpoint(string endpointName, Uri endpoint, string authenticationType)
		{
			return null;
		}

		public static void UnregisterProfile(string profileName)
		{
		}

		public static IEnumerable<string> ListProfileNames()
		{
			return null;
		}

		public static IEnumerable<ProfileSettingsBase> ListProfiles()
		{
			return null;
		}

		public static bool IsProfileKnown(string profileName)
		{
			return false;
		}

		public static string CopyProfileSettings(string sourceProfileName, string destinationProfileName)
		{
			return null;
		}

		public static string CopyProfileSettings(SettingsCollection.ObjectSettings source, string destinationProfileName)
		{
			return null;
		}

		public static bool TryGetAWSCredentials(string profileName, out AWSCredentials credentials)
		{
			credentials = null;
			return false;
		}

		public static AWSCredentials GetAWSCredentials(string profileName)
		{
			return null;
		}

		public static ProfileSettingsBase GetProfile(string profileName)
		{
			return null;
		}

		public static T GetProfile<T>(string profileName) where T : ProfileSettingsBase
		{
			return null;
		}

		public static bool TryGetProfile<T>(string profileName, out T profile) where T : ProfileSettingsBase
		{
			profile = null;
			return false;
		}

		public static bool TryGetSAMLEndpoint(string endpointName, out SAMLEndpointSettings endpointSettings)
		{
			endpointSettings = null;
			return false;
		}

		public static SAMLEndpointSettings GetSAMLEndpoint(string endpointName)
		{
			return null;
		}

		internal static SettingsCollection.ObjectSettings ReadProfileSettings(string profileName)
		{
			return null;
		}

		internal static SettingsCollection.ObjectSettings ReadProfileSettings(SettingsCollection settings, string profileName)
		{
			return null;
		}

		internal static SettingsCollection.ObjectSettings ReadSettings(SettingsCollection settings, string settingsKey)
		{
			return null;
		}
	}
}
