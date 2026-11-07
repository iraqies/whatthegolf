using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Internal
{
	public class ExecutionContext : IExecutionContext
	{
		public IRequestContext RequestContext { get; private set; }

		public IResponseContext ResponseContext { get; private set; }

		public ExecutionContext(bool enableMetrics, AbstractAWSSigner clientSigner)
		{
		}

		public ExecutionContext(IRequestContext requestContext, IResponseContext responseContext)
		{
		}

		public static IExecutionContext CreateFromAsyncContext(IAsyncExecutionContext asyncContext)
		{
			return null;
		}
	}
}
