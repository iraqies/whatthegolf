using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000143")]
	public class UserNotFoundException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x11733EC", Offset = "0x11733EC", VA = "0x11733EC")]
		public UserNotFoundException(string message)
		{
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x11733F4", Offset = "0x11733F4", VA = "0x11733F4")]
		public UserNotFoundException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x11733FC", Offset = "0x11733FC", VA = "0x11733FC")]
		public UserNotFoundException(Exception innerException)
		{
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x1173404", Offset = "0x1173404", VA = "0x1173404")]
		public UserNotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x117340C", Offset = "0x117340C", VA = "0x117340C")]
		public UserNotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
