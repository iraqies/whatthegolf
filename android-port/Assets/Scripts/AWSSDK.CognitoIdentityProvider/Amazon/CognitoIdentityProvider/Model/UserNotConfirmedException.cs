using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000142")]
	public class UserNotConfirmedException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x1173290", Offset = "0x1173290", VA = "0x1173290")]
		public UserNotConfirmedException(string message)
		{
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x1173298", Offset = "0x1173298", VA = "0x1173298")]
		public UserNotConfirmedException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x11732A0", Offset = "0x11732A0", VA = "0x11732A0")]
		public UserNotConfirmedException(Exception innerException)
		{
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x11732A8", Offset = "0x11732A8", VA = "0x11732A8")]
		public UserNotConfirmedException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x11732B0", Offset = "0x11732B0", VA = "0x11732B0")]
		public UserNotConfirmedException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
