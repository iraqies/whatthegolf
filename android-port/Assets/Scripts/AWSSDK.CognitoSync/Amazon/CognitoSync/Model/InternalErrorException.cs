using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000022")]
	public class InternalErrorException : AmazonCognitoSyncException
	{
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x119D4E4", Offset = "0x119D4E4", VA = "0x119D4E4")]
		public InternalErrorException(string message)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x119D4EC", Offset = "0x119D4EC", VA = "0x119D4EC")]
		public InternalErrorException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x119D4F4", Offset = "0x119D4F4", VA = "0x119D4F4")]
		public InternalErrorException(Exception innerException)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x119D53C", Offset = "0x119D53C", VA = "0x119D53C")]
		public InternalErrorException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x119D544", Offset = "0x119D544", VA = "0x119D544")]
		public InternalErrorException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
