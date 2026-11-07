using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace Amazon.Runtime
{
	public class HttpRequestMessageFactory : IHttpRequestFactory<HttpContent>, IDisposable
	{
		private static readonly ReaderWriterLockSlim _httpClientCacheRWLock;

		private static readonly IDictionary<string, HttpClientCache> _httpClientCaches;

		private HttpClientCache _httpClientCache;

		private bool _useGlobalHttpClientCache;

		private IClientConfig _clientConfig;

		public HttpRequestMessageFactory(IClientConfig clientConfig)
		{
		}

		public IHttpRequest<HttpContent> CreateHttpRequest(Uri requestUri)
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		private static HttpClientCache CreateHttpClientCache(IClientConfig clientConfig)
		{
			return null;
		}

		private static HttpClient CreateHttpClient(IClientConfig clientConfig)
		{
			return null;
		}

		private static HttpClient CreateManagedHttpClient(IClientConfig clientConfig)
		{
			return null;
		}
	}
}
