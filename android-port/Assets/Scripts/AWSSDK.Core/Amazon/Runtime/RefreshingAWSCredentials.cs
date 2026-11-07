using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
	public abstract class RefreshingAWSCredentials : AWSCredentials, IDisposable
	{
		public class CredentialsRefreshState
		{
			public ImmutableCredentials Credentials { get; set; }

			public DateTime Expiration { get; set; }

			public CredentialsRefreshState()
			{
			}

			public CredentialsRefreshState(ImmutableCredentials credentials, DateTime expiration)
			{
			}

			internal bool IsExpiredWithin(TimeSpan preemptExpiryTime)
			{
				return false;
			}
		}

		private Logger _logger;

		protected CredentialsRefreshState currentState;

		private TimeSpan _preemptExpiryTime;

		private bool _disposed;

		private readonly SemaphoreSlim _updateGeneratedCredentialsSemaphore;

		public TimeSpan PreemptExpiryTime
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		protected bool ShouldUpdate => false;

		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}

		public override Task<ImmutableCredentials> GetCredentialsAsync()
		{
			return null;
		}

		private static void UpdateToGeneratedCredentials(CredentialsRefreshState state, TimeSpan preemptExpiryTime)
		{
		}

		private static bool ShouldUpdateState(CredentialsRefreshState state, TimeSpan preemptExpiryTime)
		{
			return false;
		}

		protected virtual CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		protected virtual Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
		{
			return null;
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public virtual void ClearCredentials()
		{
		}

		public void Dispose()
		{
		}
	}
}
