using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000D1")]
	public class InternalErrorException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x112B100", Offset = "0x112B100", VA = "0x112B100")]
		public InternalErrorException(string message)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x112B108", Offset = "0x112B108", VA = "0x112B108")]
		public InternalErrorException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x112B110", Offset = "0x112B110", VA = "0x112B110")]
		public InternalErrorException(Exception innerException)
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x112B118", Offset = "0x112B118", VA = "0x112B118")]
		public InternalErrorException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x112B120", Offset = "0x112B120", VA = "0x112B120")]
		public InternalErrorException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
