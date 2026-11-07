using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000126")]
	public class UnsupportedIdentityProviderException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x115D820", Offset = "0x115D820", VA = "0x115D820")]
		public UnsupportedIdentityProviderException(string message)
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x115D828", Offset = "0x115D828", VA = "0x115D828")]
		public UnsupportedIdentityProviderException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x115D830", Offset = "0x115D830", VA = "0x115D830")]
		public UnsupportedIdentityProviderException(Exception innerException)
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x115D838", Offset = "0x115D838", VA = "0x115D838")]
		public UnsupportedIdentityProviderException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x115D840", Offset = "0x115D840", VA = "0x115D840")]
		public UnsupportedIdentityProviderException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
