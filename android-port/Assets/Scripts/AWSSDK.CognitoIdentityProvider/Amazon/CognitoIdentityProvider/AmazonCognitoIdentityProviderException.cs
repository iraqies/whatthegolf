using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000003")]
	public class AmazonCognitoIdentityProviderException : AmazonServiceException
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x10C7574", Offset = "0x10C7574", VA = "0x10C7574")]
		public AmazonCognitoIdentityProviderException(string message)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x10C7584", Offset = "0x10C7584", VA = "0x10C7584")]
		public AmazonCognitoIdentityProviderException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x10C75D4", Offset = "0x10C75D4", VA = "0x10C75D4")]
		public AmazonCognitoIdentityProviderException(Exception innerException)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x10C762C", Offset = "0x10C762C", VA = "0x10C762C")]
		public AmazonCognitoIdentityProviderException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x10BD8F0", Offset = "0x10BD8F0", VA = "0x10BD8F0")]
		public AmazonCognitoIdentityProviderException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
