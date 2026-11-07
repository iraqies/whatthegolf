using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000DB")]
	public class LimitExceededException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x112CBFC", Offset = "0x112CBFC", VA = "0x112CBFC")]
		public LimitExceededException(string message)
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x112CC04", Offset = "0x112CC04", VA = "0x112CC04")]
		public LimitExceededException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x112CC0C", Offset = "0x112CC0C", VA = "0x112CC0C")]
		public LimitExceededException(Exception innerException)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x112CC14", Offset = "0x112CC14", VA = "0x112CC14")]
		public LimitExceededException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x112CC1C", Offset = "0x112CC1C", VA = "0x112CC1C")]
		public LimitExceededException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
