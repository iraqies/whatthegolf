using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000F0")]
	public class HttpRequestMessageFactory : IHttpRequestFactory<HttpContent>, IDisposable
	{
		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ReaderWriterLockSlim _httpClientCacheRWLock;

		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IDictionary<string, HttpClientCache> _httpClientCaches;

		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x10")]
		private HttpClientCache _httpClientCache;

		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x18")]
		private bool _useGlobalHttpClientCache;

		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x20")]
		private IClientConfig _clientConfig;

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x1210C08", Offset = "0x1210C08", VA = "0x1210C08")]
		public HttpRequestMessageFactory(IClientConfig clientConfig)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x1210C34", Offset = "0x1210C34", VA = "0x1210C34", Slot = "4")]
		public IHttpRequest<HttpContent> CreateHttpRequest(Uri requestUri)
		{
			return null;
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x12116B8", Offset = "0x12116B8", VA = "0x12116B8", Slot = "5")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x1211738", Offset = "0x1211738", VA = "0x1211738", Slot = "6")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x12112F0", Offset = "0x12112F0", VA = "0x12112F0")]
		private static HttpClientCache CreateHttpClientCache(IClientConfig clientConfig)
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x12114A8", Offset = "0x12114A8", VA = "0x12114A8")]
		private static HttpClient CreateHttpClient(IClientConfig clientConfig)
		{
			return null;
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x12117D8", Offset = "0x12117D8", VA = "0x12117D8")]
		private static HttpClient CreateManagedHttpClient(IClientConfig clientConfig)
		{
			return null;
		}
	}
}
