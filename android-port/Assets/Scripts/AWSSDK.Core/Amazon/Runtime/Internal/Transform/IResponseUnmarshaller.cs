using System;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000216")]
	public interface IResponseUnmarshaller<T, R> : IUnmarshaller<T, R>
	{
		[Token(Token = "0x6001015")]
		AmazonServiceException UnmarshallException(R input, Exception innerException, HttpStatusCode statusCode);
	}
}
