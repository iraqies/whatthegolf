using System;
using System.Net.Http;

namespace Amazon.Runtime
{
	public class HttpClientCache : IDisposable
	{
		private HttpClient[] _clients;

		private int count;

		public HttpClientCache(HttpClient[] clients)
		{
		}

		public HttpClient GetNextClient()
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
