using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class CSMCallEventHandler : PipelineHandler
	{
		private Stopwatch stopWatch;

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		private void CSMCallEventMetricsCapture(IExecutionContext executionContext)
		{
		}

		private static void CaptureCSMCallEventExceptionData(IRequestContext requestContext, Exception exception)
		{
		}

		protected void PreInvoke(IExecutionContext executionContext)
		{
		}
	}
}
