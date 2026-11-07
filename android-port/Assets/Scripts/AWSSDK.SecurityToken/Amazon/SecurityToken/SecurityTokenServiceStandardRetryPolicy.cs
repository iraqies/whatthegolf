using System;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken
{
	public class SecurityTokenServiceStandardRetryPolicy : StandardRetryPolicy
	{
		public SecurityTokenServiceStandardRetryPolicy(IClientConfig config)
			: base(0)
		{
		}

		public override bool RetryForException(IExecutionContext executionContext, Exception exception)
		{
			return false;
		}

		public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}
	}
}
