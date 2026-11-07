using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement.Internal;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.CredentialManagement
{
	public class SharedCredentialsFile : ICredentialProfileStore, ICredentialProfileSource
	{
		public const string DefaultProfileName = "default";

		private const string ToolkitArtifactGuidField = "toolkit_artifact_guid";

		private const string RegionField = "region";

		private const string EndpointDiscoveryEnabledField = "endpoint_discovery_enabled";

		private const string ConfigFileName = "config";

		private const string DefaultDirectoryName = ".aws";

		private const string DefaultFileName = "credentials";

		private const string CredentialProcess = "credential_process";

		private const string StsRegionalEndpointsField = "sts_regional_endpoints";

		private const string S3UseArnRegionField = "s3_use_arn_region";

		private const string S3RegionalEndpointField = "s3_us_east_1_regional_endpoint";

		private const string RetryModeField = "retry_mode";

		private const string MaxAttemptsField = "max_attempts";

		private readonly Logger _logger;

		private static readonly HashSet<string> ReservedPropertyNames;

		private static readonly HashSet<CredentialProfileType> ProfileTypeWhitelist;

		private static readonly CredentialProfilePropertyMapping PropertyMapping;

		public static readonly string DefaultDirectory;

		public static readonly string DefaultFilePath;

		private ProfileIniFile _credentialsFile;

		private ProfileIniFile _configFile;

		public string FilePath { get; private set; }

		static SharedCredentialsFile()
		{
		}

		public SharedCredentialsFile()
		{
		}

		public SharedCredentialsFile(string filePath)
		{
		}

		private void SetUpFilePath(string filePath)
		{
		}

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

		private void RegisterProfileInternal(CredentialProfile profile)
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

		private void Refresh()
		{
		}

		private HashSet<string> ListAllProfileNames()
		{
			return null;
		}

		private bool TryGetProfile(string profileName, bool doRefresh, out CredentialProfile profile)
		{
			profile = null;
			return false;
		}

		private bool TryGetSection(string sectionName, out Dictionary<string, string> iniProperties)
		{
			iniProperties = null;
			return false;
		}

		private static bool IsSupportedProfileType(CredentialProfileType? profileType)
		{
			return false;
		}
	}
}
