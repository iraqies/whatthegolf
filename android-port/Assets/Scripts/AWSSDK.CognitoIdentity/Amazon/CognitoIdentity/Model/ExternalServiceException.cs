using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000028")]
	public class ExternalServiceException : AmazonCognitoIdentityException
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1083EE0", Offset = "0x1083EE0", VA = "0x1083EE0")]
		public ExternalServiceException(string message)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1083EE8", Offset = "0x1083EE8", VA = "0x1083EE8")]
		public ExternalServiceException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1083EF0", Offset = "0x1083EF0", VA = "0x1083EF0")]
		public ExternalServiceException(Exception innerException)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1083F38", Offset = "0x1083F38", VA = "0x1083F38")]
		public ExternalServiceException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1083F40", Offset = "0x1083F40", VA = "0x1083F40")]
		public ExternalServiceException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
