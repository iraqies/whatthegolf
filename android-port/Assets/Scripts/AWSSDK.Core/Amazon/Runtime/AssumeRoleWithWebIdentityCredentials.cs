using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;

namespace Amazon.Runtime
{
	public class AssumeRoleWithWebIdentityCredentials : RefreshingAWSCredentials
	{
		private const int PREEMPT_EXPIRY_MINUTES = 5;

		private static readonly RegionEndpoint _defaultSTSClientRegion;

		private static readonly string _roleSessionNameDefault;

		public const string WebIdentityTokenFileEnvVariable = "AWS_WEB_IDENTITY_TOKEN_FILE";

		public const string RoleArnEnvVariable = "AWS_ROLE_ARN";

		public const string RoleSessionNameEnvVariable = "AWS_ROLE_SESSION_NAME";

		private static readonly Regex _roleSessionNameRegex;

		private readonly Logger _logger;

		private AssumeRoleWithWebIdentityCredentialsOptions _options;

		public string WebIdentityTokenFile { get; }

		public string RoleArn { get; }

		public string RoleSessionName { get; }

		public AssumeRoleWithWebIdentityCredentials(string webIdentityTokenFile, string roleArn, string roleSessionName)
		{
		}

		public AssumeRoleWithWebIdentityCredentials(string webIdentityTokenFile, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
		{
		}

		public static AssumeRoleWithWebIdentityCredentials FromEnvironmentVariables()
		{
			return null;
		}

		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
		{
			return null;
		}

		protected virtual ICoreAmazonSTS_WebIdentity CreateClient()
		{
			return null;
		}
	}
}
