using System;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class CSMCallAttemptHandler : PipelineHandler
	{
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		protected static void CSMCallAttemptMetricsCapture(IRequestContext requestContext, IResponseContext responseContext)
		{
		}

		protected virtual void PreInvoke(IExecutionContext executionContext)
		{
		}

		private static void CaptureSDKExceptionMessage(MonitoringAPICallAttempt monitoringAPICallAttempt, Exception e)
		{
		}

		private static void CaptureAmazonException(MonitoringAPICallAttempt monitoringAPICallAttempt, AmazonServiceException e)
		{
		}
	}
}
