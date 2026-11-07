using System.Net;

namespace Amazon.Runtime
{
	public class ECSTaskCredentials : URIBasedRefreshingCredentialHelper
	{
		public const string ContainerCredentialsURIEnvVariable = "AWS_CONTAINER_CREDENTIALS_RELATIVE_URI";

		public const string EndpointAddress = "http://169.254.170.2";

		private string Uri;

		private string Server;

		private static int MaxRetries;

		private IWebProxy Proxy;

		public ECSTaskCredentials()
		{
		}

		public ECSTaskCredentials(IWebProxy proxy)
		{
		}

		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}
	}
}
