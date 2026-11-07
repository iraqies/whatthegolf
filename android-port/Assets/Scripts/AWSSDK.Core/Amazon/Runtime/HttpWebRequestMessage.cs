using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Runtime
{
	public class HttpWebRequestMessage : IHttpRequest<HttpContent>, IDisposable
	{
		private static HashSet<string> ContentHeaderNames;

		private bool _disposed;

		private HttpRequestMessage _request;

		private HttpClient _httpClient;

		private IClientConfig _clientConfig;

		public HttpClient HttpClient => null;

		public HttpRequestMessage Request => null;

		public string Method
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Uri RequestUri => null;

		public HttpWebRequestMessage(HttpClient httpClient, Uri requestUri, IClientConfig config)
		{
		}

		public void ConfigureRequest(IRequestContext requestContext)
		{
		}

		public void SetRequestHeaders(IDictionary<string, string> headers)
		{
		}

		public HttpContent GetRequestContent()
		{
			return null;
		}

		public IWebResponseData GetResponse()
		{
			return null;
		}

		public void Abort()
		{
		}

		public Task<IWebResponseData> GetResponseAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public void WriteToRequestBody(HttpContent requestContent, Stream contentStream, IDictionary<string, string> contentHeaders, IRequestContext requestContext)
		{
		}

		public void WriteToRequestBody(HttpContent requestContent, byte[] content, IDictionary<string, string> contentHeaders)
		{
		}

		public Task<HttpContent> GetRequestContentAsync()
		{
			return null;
		}

		private void WriteContentHeaders(IDictionary<string, string> contentHeaders)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public Stream SetupProgressListeners(Stream originalStream, long progressUpdateInterval, object sender, EventHandler<StreamTransferProgressArgs> callback)
		{
			return null;
		}
	}
}
