using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Transform
{
	public class HttpResponseMessageBody : IHttpResponseBody, IDisposable
	{
		private HttpClient _httpClient;

		private HttpResponseMessage _response;

		private bool _disposeClient;

		private bool _disposed;

		public HttpResponseMessageBody(HttpResponseMessage response, HttpClient httpClient, bool disposeClient)
		{
		}

		public Stream OpenResponse()
		{
			return null;
		}

		public Task<Stream> OpenResponseAsync()
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
