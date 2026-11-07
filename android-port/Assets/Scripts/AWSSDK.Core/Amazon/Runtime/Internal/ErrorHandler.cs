using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class ErrorHandler : PipelineHandler
	{
		private IDictionary<Type, IExceptionHandler> _exceptionHandlers;

		public IDictionary<Type, IExceptionHandler> ExceptionHandlers => null;

		public ErrorHandler(ILogger logger)
		{
		}

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		private static void DisposeReponse(IResponseContext responseContext)
		{
		}

		private bool ProcessException(IExecutionContext executionContext, Exception exception)
		{
			return false;
		}
	}
}
