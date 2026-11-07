using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000038")]
	public class LimitExceededException : AmazonCognitoIdentityException
	{
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x108D780", Offset = "0x108D780", VA = "0x108D780")]
		public LimitExceededException(string message)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x108D788", Offset = "0x108D788", VA = "0x108D788")]
		public LimitExceededException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x108D790", Offset = "0x108D790", VA = "0x108D790")]
		public LimitExceededException(Exception innerException)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x108D7D8", Offset = "0x108D7D8", VA = "0x108D7D8")]
		public LimitExceededException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x108D7E0", Offset = "0x108D7E0", VA = "0x108D7E0")]
		public LimitExceededException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
