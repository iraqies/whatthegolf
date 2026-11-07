using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000F9")]
	public class PasswordResetRequiredException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1140BF8", Offset = "0x1140BF8", VA = "0x1140BF8")]
		public PasswordResetRequiredException(string message)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x1140C00", Offset = "0x1140C00", VA = "0x1140C00")]
		public PasswordResetRequiredException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x1140C08", Offset = "0x1140C08", VA = "0x1140C08")]
		public PasswordResetRequiredException(Exception innerException)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x1140C10", Offset = "0x1140C10", VA = "0x1140C10")]
		public PasswordResetRequiredException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x1140C18", Offset = "0x1140C18", VA = "0x1140C18")]
		public PasswordResetRequiredException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
