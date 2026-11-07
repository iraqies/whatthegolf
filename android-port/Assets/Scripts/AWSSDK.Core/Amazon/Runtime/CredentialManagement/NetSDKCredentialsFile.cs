using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement.Internal;
using Amazon.Util.Internal;

namespace Amazon.Runtime.CredentialManagement
{
	public class NetSDKCredentialsFile : ICredentialProfileStore, ICredentialProfileSource
	{
		public const string DefaultProfileName = "Default";

		private const string AWSCredentialsProfileType = "AWS";

		private const string SAMLRoleProfileType = "SAML";

		private const string RegionField = "Region";

		private const string EndpointDiscoveryEnabledField = "EndpointDiscoveryEnabled";

		private const string S3UseArnRegionField = "S3UseArnRegion";

		private const string StsRegionalEndpointsField = "StsRegionalEndpoints";

		private const string S3RegionalEndpointField = "S3RegionalEndpoint";

		private const string RetryModeField = "RetryMode";

		private const string MaxAttemptsField = "MaxAttempts";

		private static readonly HashSet<string> ReservedPropertyNames;

		private static readonly CredentialProfilePropertyMapping PropertyMapping;

		private readonly NamedSettingsManager _settingsManager;

		public List<string> ListProfileNames()
		{
			return null;
		}

		public List<CredentialProfile> ListProfiles()
		{
			return null;
		}

		public bool TryGetProfile(string profileName, out CredentialProfile profile)
		{
			profile = null;
			return false;
		}

		public void RegisterProfile(CredentialProfile profile)
		{
		}

		public void UnregisterProfile(string profileName)
		{
		}

		public void RenameProfile(string oldProfileName, string newProfileName)
		{
		}

		public void RenameProfile(string oldProfileName, string newProfileName, bool force)
		{
		}

		public void CopyProfile(string fromProfileName, string toProfileName)
		{
		}

		public void CopyProfile(string fromProfileName, string toProfileName, bool force)
		{
		}

		private static void SetProfileTypeField(IDictionary<string, string> properties, CredentialProfileType profileType)
		{
		}
	}
}
