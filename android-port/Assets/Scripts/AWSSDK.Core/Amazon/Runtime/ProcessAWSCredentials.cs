using System.Diagnostics;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.Runtime
{
	public class ProcessAWSCredentials : RefreshingAWSCredentials
	{
		private const string _versionString = "Version";

		private Logger _logger;

		private readonly ProcessStartInfo _processStartInfo;

		public ProcessAWSCredentials(string processCredentialInfo)
		{
		}

		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
		{
			return null;
		}

		public CredentialsRefreshState DetermineProcessCredential()
		{
			return null;
		}

		public Task<CredentialsRefreshState> DetermineProcessCredentialAsync()
		{
			return null;
		}

		private CredentialsRefreshState SetCredentialsRefreshState(ProcessExecutionResult processInfo)
		{
			return null;
		}
	}
}
