using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200003C")]
	public class TooManyRequestsException : AmazonCognitoSyncException
	{
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x11AB7FC", Offset = "0x11AB7FC", VA = "0x11AB7FC")]
		public TooManyRequestsException(string message)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x11AB804", Offset = "0x11AB804", VA = "0x11AB804")]
		public TooManyRequestsException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x11AB80C", Offset = "0x11AB80C", VA = "0x11AB80C")]
		public TooManyRequestsException(Exception innerException)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x11AB854", Offset = "0x11AB854", VA = "0x11AB854")]
		public TooManyRequestsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x11AB85C", Offset = "0x11AB85C", VA = "0x11AB85C")]
		public TooManyRequestsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
