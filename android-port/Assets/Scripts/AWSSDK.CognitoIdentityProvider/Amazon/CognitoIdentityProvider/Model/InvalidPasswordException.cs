using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000D6")]
	public class InvalidPasswordException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x112B8B0", Offset = "0x112B8B0", VA = "0x112B8B0")]
		public InvalidPasswordException(string message)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x112B8B8", Offset = "0x112B8B8", VA = "0x112B8B8")]
		public InvalidPasswordException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x112B8C0", Offset = "0x112B8C0", VA = "0x112B8C0")]
		public InvalidPasswordException(Exception innerException)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x112B8C8", Offset = "0x112B8C8", VA = "0x112B8C8")]
		public InvalidPasswordException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x112B8D0", Offset = "0x112B8D0", VA = "0x112B8D0")]
		public InvalidPasswordException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
