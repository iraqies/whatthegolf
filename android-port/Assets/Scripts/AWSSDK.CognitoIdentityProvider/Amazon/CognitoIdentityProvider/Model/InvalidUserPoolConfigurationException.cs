using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000D9")]
	public class InvalidUserPoolConfigurationException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x112BDA8", Offset = "0x112BDA8", VA = "0x112BDA8")]
		public InvalidUserPoolConfigurationException(string message)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x112BDB0", Offset = "0x112BDB0", VA = "0x112BDB0")]
		public InvalidUserPoolConfigurationException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x112BDB8", Offset = "0x112BDB8", VA = "0x112BDB8")]
		public InvalidUserPoolConfigurationException(Exception innerException)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x112BDC0", Offset = "0x112BDC0", VA = "0x112BDC0")]
		public InvalidUserPoolConfigurationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x112BDC8", Offset = "0x112BDC8", VA = "0x112BDC8")]
		public InvalidUserPoolConfigurationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
