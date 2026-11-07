using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000122")]
	public class TooManyFailedAttemptsException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x115C8AC", Offset = "0x115C8AC", VA = "0x115C8AC")]
		public TooManyFailedAttemptsException(string message)
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x115C8B4", Offset = "0x115C8B4", VA = "0x115C8B4")]
		public TooManyFailedAttemptsException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x115C8BC", Offset = "0x115C8BC", VA = "0x115C8BC")]
		public TooManyFailedAttemptsException(Exception innerException)
		{
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x115C8C4", Offset = "0x115C8C4", VA = "0x115C8C4")]
		public TooManyFailedAttemptsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x115C8CC", Offset = "0x115C8CC", VA = "0x115C8CC")]
		public TooManyFailedAttemptsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
