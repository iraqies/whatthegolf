using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class RuntimePipeline : IDisposable
	{
		private bool _disposed;

		private ILogger _logger;

		private IPipelineHandler _handler;

		public IPipelineHandler Handler => null;

		public List<IPipelineHandler> Handlers => null;

		public RuntimePipeline(IPipelineHandler handler)
		{
		}

		public RuntimePipeline(IList<IPipelineHandler> handlers)
		{
		}

		public RuntimePipeline(IList<IPipelineHandler> handlers, ILogger logger)
		{
		}

		public RuntimePipeline(IPipelineHandler handler, ILogger logger)
		{
		}

		public IResponseContext InvokeSync(IExecutionContext executionContext)
		{
			return null;
		}

		public Task<T> InvokeAsync<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}

		public void AddHandler(IPipelineHandler handler)
		{
		}

		public void AddHandlerAfter<T>(IPipelineHandler handler) where T : IPipelineHandler
		{
		}

		public void AddHandlerBefore<T>(IPipelineHandler handler) where T : IPipelineHandler
		{
		}

		public void RemoveHandler<T>()
		{
		}

		public void ReplaceHandler<T>(IPipelineHandler handler) where T : IPipelineHandler
		{
		}

		private static void InsertHandler(IPipelineHandler handler, IPipelineHandler current)
		{
		}

		private static IPipelineHandler GetInnermostHandler(IPipelineHandler handler)
		{
			return null;
		}

		private void SetHandlerProperties(IPipelineHandler handler)
		{
		}

		public IEnumerable<IPipelineHandler> EnumerateHandlers()
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		private void ThrowIfDisposed()
		{
		}
	}
}
