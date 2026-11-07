using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
	public class EnvironmentVariablesAWSCredentials : AWSCredentials
	{
		public const string ENVIRONMENT_VARIABLE_ACCESSKEY = "AWS_ACCESS_KEY_ID";

		public const string ENVIRONMENT_VARIABLE_SECRETKEY = "AWS_SECRET_ACCESS_KEY";

		public const string ENVIRONMENT_VARIABLE_SESSION_TOKEN = "AWS_SESSION_TOKEN";

		public const string LEGACY_ENVIRONMENT_VARIABLE_SECRETKEY = "AWS_SECRET_KEY";

		private Logger logger;

		public ImmutableCredentials FetchCredentials()
		{
			return null;
		}

		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}
	}
}
