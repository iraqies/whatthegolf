using System;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class RetryHandler : PipelineHandler
	{
		private ILogger _logger;

		public override ILogger Logger
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RetryPolicy RetryPolicy { get; private set; }

		public RetryHandler(RetryPolicy retryPolicy)
		{
		}

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		internal static void PrepareForRetry(IRequestContext requestContext)
		{
		}

		private void LogForRetry(IRequestContext requestContext, Exception exception)
		{
		}

		private void LogForError(IRequestContext requestContext, Exception exception)
		{
		}
	}
}
