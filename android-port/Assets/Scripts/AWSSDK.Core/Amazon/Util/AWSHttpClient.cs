using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Amazon.Util
{
	public class AWSHttpClient : IDisposable
	{
		private HttpClient _httpClient;

		private bool disposed;

		public Uri BaseAddress
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TimeSpan Timeout
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public long MaxResponseContentBufferSize
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public AWSHttpClient()
		{
		}

		internal AWSHttpClient(IWebProxy proxy, bool useProxy)
		{
		}

		internal AWSHttpClient(HttpMessageHandler handler)
		{
		}

		internal AWSHttpClient(HttpMessageHandler handler, bool disposeHandler)
		{
		}

		public Task<Stream> GetStreamAsync(string requestUri)
		{
			return null;
		}

		public Task PutRequestUriAsync(string requestUri, AWSStreamContent content, IDictionary<string, string> requestHeaders)
		{
			return null;
		}

		public Task<List<Tuple<string, IEnumerable<string>, HttpStatusCode>>> GetResponseHeadersAsync(string httpMethodValue, string url)
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public static bool IsHttpInnerException(Exception exception)
		{
			return false;
		}
	}
}
