using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000AC")]
	public class DuplicateProviderException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1110340", Offset = "0x1110340", VA = "0x1110340")]
		public DuplicateProviderException(string message)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1110348", Offset = "0x1110348", VA = "0x1110348")]
		public DuplicateProviderException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1110350", Offset = "0x1110350", VA = "0x1110350")]
		public DuplicateProviderException(Exception innerException)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1110358", Offset = "0x1110358", VA = "0x1110358")]
		public DuplicateProviderException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1110360", Offset = "0x1110360", VA = "0x1110360")]
		public DuplicateProviderException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
