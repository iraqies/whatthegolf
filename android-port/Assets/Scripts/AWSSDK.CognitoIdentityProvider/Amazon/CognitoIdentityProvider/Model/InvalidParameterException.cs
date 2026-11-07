using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000D5")]
	public class InvalidParameterException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x112B754", Offset = "0x112B754", VA = "0x112B754")]
		public InvalidParameterException(string message)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x112B75C", Offset = "0x112B75C", VA = "0x112B75C")]
		public InvalidParameterException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x112B764", Offset = "0x112B764", VA = "0x112B764")]
		public InvalidParameterException(Exception innerException)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x112B76C", Offset = "0x112B76C", VA = "0x112B76C")]
		public InvalidParameterException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x112B774", Offset = "0x112B774", VA = "0x112B774")]
		public InvalidParameterException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
