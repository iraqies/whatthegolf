using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Internal
{
	public class AsyncExecutionContext : IAsyncExecutionContext
	{
		public IAsyncResponseContext ResponseContext { get; private set; }

		public IAsyncRequestContext RequestContext { get; private set; }

		public object RuntimeState { get; set; }

		public AsyncExecutionContext(bool enableMetrics, AbstractAWSSigner clientSigner)
		{
		}

		public AsyncExecutionContext(IAsyncRequestContext requestContext, IAsyncResponseContext responseContext)
		{
		}
	}
}
