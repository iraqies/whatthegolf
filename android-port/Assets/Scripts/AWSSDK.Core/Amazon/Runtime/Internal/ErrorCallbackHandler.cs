using System;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class ErrorCallbackHandler : PipelineHandler
	{
		public Action<IExecutionContext, Exception> OnError { get; set; }

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		protected void HandleException(IExecutionContext executionContext, Exception exception)
		{
		}
	}
}
