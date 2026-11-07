using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class DefaultRetryPolicy : RetryPolicy
	{
		private const int INVALID_ENDPOINT_EXCEPTION_STATUSCODE = 421;

		private static readonly CapacityManager _capacityManagerInstance;

		private static readonly HashSet<string> _netStandardRetryErrorMessages;

		public int MaxBackoffInMilliseconds { get; set; }

		public DefaultRetryPolicy(int maxRetries)
		{
		}

		public DefaultRetryPolicy(IClientConfig config)
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

		private bool RetryForExceptionSync(Exception exception)
		{
			return false;
		}

		private bool RetryForExceptionSync(Exception exception, IExecutionContext executionContext)
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

		private static int CalculateRetryDelay(int retries, int maxBackoffInMilliseconds)
		{
			return 0;
		}

		[Obsolete]
		protected static bool ContainErrorMessage(Exception exception)
		{
			return false;
		}

		[Obsolete]
		protected static bool IsInnerException<T>(Exception exception) where T : Exception
		{
			return false;
		}

		[Obsolete]
		protected static bool IsInnerException<T>(Exception exception, out T inner) where T : Exception
		{
			inner = null;
			return false;
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
