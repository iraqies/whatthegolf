using System;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000ED")]
	public interface IHttpRequestFactory<TRequestContent> : IDisposable
	{
		[Token(Token = "0x6000822")]
		IHttpRequest<TRequestContent> CreateHttpRequest(Uri requestUri);
	}
}
