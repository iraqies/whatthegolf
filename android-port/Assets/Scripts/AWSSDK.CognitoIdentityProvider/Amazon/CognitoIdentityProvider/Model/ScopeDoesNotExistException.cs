using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000108")]
	public class ScopeDoesNotExistException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x114B508", Offset = "0x114B508", VA = "0x114B508")]
		public ScopeDoesNotExistException(string message)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x114B510", Offset = "0x114B510", VA = "0x114B510")]
		public ScopeDoesNotExistException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x114B518", Offset = "0x114B518", VA = "0x114B518")]
		public ScopeDoesNotExistException(Exception innerException)
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x114B520", Offset = "0x114B520", VA = "0x114B520")]
		public ScopeDoesNotExistException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x114B528", Offset = "0x114B528", VA = "0x114B528")]
		public ScopeDoesNotExistException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
