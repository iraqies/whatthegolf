using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000100")]
	public class ResourceNotFoundException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x1144B28", Offset = "0x1144B28", VA = "0x1144B28")]
		public ResourceNotFoundException(string message)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x1144B30", Offset = "0x1144B30", VA = "0x1144B30")]
		public ResourceNotFoundException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x1144B38", Offset = "0x1144B38", VA = "0x1144B38")]
		public ResourceNotFoundException(Exception innerException)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x1144B40", Offset = "0x1144B40", VA = "0x1144B40")]
		public ResourceNotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x1144B48", Offset = "0x1144B48", VA = "0x1144B48")]
		public ResourceNotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
