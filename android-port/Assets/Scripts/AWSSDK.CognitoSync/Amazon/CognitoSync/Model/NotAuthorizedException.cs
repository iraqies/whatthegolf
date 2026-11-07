using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200002E")]
	public class NotAuthorizedException : AmazonCognitoSyncException
	{
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x11A3B2C", Offset = "0x11A3B2C", VA = "0x11A3B2C")]
		public NotAuthorizedException(string message)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x11A3B34", Offset = "0x11A3B34", VA = "0x11A3B34")]
		public NotAuthorizedException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x11A3B3C", Offset = "0x11A3B3C", VA = "0x11A3B3C")]
		public NotAuthorizedException(Exception innerException)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x11A3B84", Offset = "0x11A3B84", VA = "0x11A3B84")]
		public NotAuthorizedException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x11A3B8C", Offset = "0x11A3B8C", VA = "0x11A3B8C")]
		public NotAuthorizedException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
