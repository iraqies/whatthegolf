using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
	internal class DefaultInstanceProfileAWSCredentials : AWSCredentials, IDisposable
	{
		private static object instanceLock;

		private Timer credentialsRetrieverTimer;

		private ImmutableCredentials lastRetrievedCredentials;

		private Logger logger;

		private static readonly TimeSpan neverTimespan;

		private static readonly TimeSpan refreshRate;

		private const string FailedToGetCredentialsMessage = "Failed to retrieve credentials from EC2 Instance Metadata Service.";

		private static DefaultInstanceProfileAWSCredentials _instance;

		private bool isDisposed;

		public static DefaultInstanceProfileAWSCredentials Instance => null;

		private DefaultInstanceProfileAWSCredentials()
		{
		}

		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}

		public override Task<ImmutableCredentials> GetCredentialsAsync()
		{
			return null;
		}

		private void RenewCredentials(object unused)
		{
		}

		private static ImmutableCredentials FetchCredentials()
		{
			return null;
		}

		private static void CheckIsIMDSEnabled()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}
	}
}
