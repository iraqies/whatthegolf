using System;
using System.IO;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class HttpHandler<TRequestContent> : PipelineHandler, IDisposable
	{
		private bool _disposed;

		private IHttpRequestFactory<TRequestContent> _requestFactory;

		public object CallbackSender { get; private set; }

		public HttpHandler(IHttpRequestFactory<TRequestContent> requestFactory, object callbackSender)
		{
		}

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		private static void CompleteFailedRequest(IHttpRequest<TRequestContent> httpRequest)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		private static Task CompleteFailedRequest(IExecutionContext executionContext, IHttpRequest<TRequestContent> httpRequest)
		{
			return null;
		}

		private static void SetMetrics(IRequestContext requestContext)
		{
		}

		private void WriteContentToRequestBody(TRequestContent requestContent, IHttpRequest<TRequestContent> httpRequest, IRequestContext requestContext)
		{
		}

		protected virtual IHttpRequest<TRequestContent> CreateWebRequest(IRequestContext requestContext)
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		private static Stream GetInputStream(IRequestContext requestContext, Stream originalStream, IRequest wrappedRequest)
		{
			return null;
		}
	}
}
