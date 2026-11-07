using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000B2")]
	public class ExpiredCodeException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1112EF4", Offset = "0x1112EF4", VA = "0x1112EF4")]
		public ExpiredCodeException(string message)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1112EFC", Offset = "0x1112EFC", VA = "0x1112EFC")]
		public ExpiredCodeException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1112F04", Offset = "0x1112F04", VA = "0x1112F04")]
		public ExpiredCodeException(Exception innerException)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1112F0C", Offset = "0x1112F0C", VA = "0x1112F0C")]
		public ExpiredCodeException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1112F14", Offset = "0x1112F14", VA = "0x1112F14")]
		public ExpiredCodeException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
