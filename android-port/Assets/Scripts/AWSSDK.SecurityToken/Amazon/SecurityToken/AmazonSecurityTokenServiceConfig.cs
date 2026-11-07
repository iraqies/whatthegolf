using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;

namespace Amazon.SecurityToken
{
	public class AmazonSecurityTokenServiceConfig : ClientConfig
	{
		private StsRegionalEndpointsValue? _stsRegionalEndpoints;

		private const string AwsProfileEnvironmentVariable = "AWS_PROFILE";

		private const string DefaultProfileName = "default";

		private const string AwsStsRegionalEndpointsEnvironmentVariable = "AWS_STS_REGIONAL_ENDPOINTS";

		private const string StsDefaultHostname = "https://sts.amazonaws.com";

		private static CredentialProfileStoreChain credentialProfileChain;

		private readonly ISet<RegionEndpoint> legacyGlobalRegions;

		private static readonly string UserAgentString;

		private string _userAgent;

		public StsRegionalEndpointsValue StsRegionalEndpoints
		{
			get
			{
				return StsRegionalEndpointsValue.Legacy;
			}
			set
			{
			}
		}

		public override string RegionEndpointServiceName => null;

		public override string ServiceVersion => null;

		public override string UserAgent => null;

		public override string DetermineServiceURL()
		{
			return null;
		}

		internal static string GetUrl(RegionEndpoint regionEndpoint, string regionEndpointServiceName, bool useHttp, bool useDualStack)
		{
			return null;
		}

		private static StsRegionalEndpointsValue? CheckSTSEnvironmentVariable()
		{
			return null;
		}

		private static StsRegionalEndpointsValue? CheckCredentialsFile()
		{
			return null;
		}
	}
}
