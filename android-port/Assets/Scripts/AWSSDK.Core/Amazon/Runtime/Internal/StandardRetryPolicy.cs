using System;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class StandardRetryPolicy : RetryPolicy
	{
		private static Random _randomJitter;

		private const int INVALID_ENDPOINT_EXCEPTION_STATUSCODE = 421;

		protected static CapacityManager CapacityManagerInstance { get; set; }

		public int MaxBackoffInMilliseconds { get; set; }

		public StandardRetryPolicy(int maxRetries)
		{
		}

		public StandardRetryPolicy(IClientConfig config)
		{
		}

		public override bool CanRetry(IExecutionContext executionContext)
		{
			return false;
		}

		public override bool RetryForException(IExecutionContext executionContext, Exception exception)
		{
			return false;
		}

		public override bool OnRetry(IExecutionContext executionContext)
		{
			return false;
		}

		public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity)
		{
			return false;
		}

		public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity, bool isThrottlingError)
		{
			return false;
		}

		public override void NotifySuccess(IExecutionContext executionContext)
		{
		}

		protected bool RetryForExceptionSync(Exception exception)
		{
			return false;
		}

		protected bool RetryForExceptionSync(Exception exception, IExecutionContext executionContext)
		{
			return false;
		}

		public override bool RetryLimitReached(IExecutionContext executionContext)
		{
			return false;
		}

		public override void WaitBeforeRetry(IExecutionContext executionContext)
		{
		}

		public static void WaitBeforeRetry(int retries, int maxBackoffInMilliseconds)
		{
		}

		protected static int CalculateRetryDelay(int retries, int maxBackoffInMilliseconds)
		{
			return 0;
		}

		public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}

		public override Task WaitBeforeRetryAsync(IExecutionContext executionContext)
		{
			return null;
		}
	}
}
