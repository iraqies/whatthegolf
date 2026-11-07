using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
	public class AssumeRoleAWSCredentials : RefreshingAWSCredentials
	{
		private RegionEndpoint DefaultSTSClientRegion;

		private Logger _logger;

		public AWSCredentials SourceCredentials { get; private set; }

		public string RoleArn { get; private set; }

		public string RoleSessionName { get; private set; }

		public AssumeRoleAWSCredentialsOptions Options { get; private set; }

		public AssumeRoleAWSCredentials(AWSCredentials sourceCredentials, string roleArn, string roleSessionName)
		{
		}

		public AssumeRoleAWSCredentials(AWSCredentials sourceCredentials, string roleArn, string roleSessionName, AssumeRoleAWSCredentialsOptions options)
		{
		}

		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}
	}
}
