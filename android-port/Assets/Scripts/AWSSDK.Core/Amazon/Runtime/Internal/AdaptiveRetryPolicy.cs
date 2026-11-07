using System;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class AdaptiveRetryPolicy : StandardRetryPolicy
	{
		protected TokenBucket TokenBucket { get; set; }

		public AdaptiveRetryPolicy(int maxRetries)
			: base(0)
		{
		}

		public AdaptiveRetryPolicy(IClientConfig config)
			: base(0)
		{
		}

		public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity, bool isThrottlingError)
		{
			return false;
		}

		public override void ObtainSendToken(IExecutionContext executionContext, Exception exception)
		{
		}

		public override void NotifySuccess(IExecutionContext executionContext)
		{
		}

		public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}

		public override Task WaitBeforeRetryAsync(IExecutionContext executionContext)
		{
			return null;
		}

		public override Task ObtainSendTokenAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}
	}
}
