using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000125")]
	public class UnexpectedLambdaException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x115D5E0", Offset = "0x115D5E0", VA = "0x115D5E0")]
		public UnexpectedLambdaException(string message)
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x115D5E8", Offset = "0x115D5E8", VA = "0x115D5E8")]
		public UnexpectedLambdaException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x115D5F0", Offset = "0x115D5F0", VA = "0x115D5F0")]
		public UnexpectedLambdaException(Exception innerException)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x115D5F8", Offset = "0x115D5F8", VA = "0x115D5F8")]
		public UnexpectedLambdaException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x115D600", Offset = "0x115D600", VA = "0x115D600")]
		public UnexpectedLambdaException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
