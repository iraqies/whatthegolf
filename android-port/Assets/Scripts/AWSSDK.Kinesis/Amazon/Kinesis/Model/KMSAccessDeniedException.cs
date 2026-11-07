using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000030")]
	public class KMSAccessDeniedException : AmazonKinesisException
	{
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x12B5A4C", Offset = "0x12B5A4C", VA = "0x12B5A4C")]
		public KMSAccessDeniedException(string message)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x12B5A54", Offset = "0x12B5A54", VA = "0x12B5A54")]
		public KMSAccessDeniedException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x12B5A5C", Offset = "0x12B5A5C", VA = "0x12B5A5C")]
		public KMSAccessDeniedException(Exception innerException)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x12B5AA4", Offset = "0x12B5AA4", VA = "0x12B5AA4")]
		public KMSAccessDeniedException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x12B5AAC", Offset = "0x12B5AAC", VA = "0x12B5AAC")]
		public KMSAccessDeniedException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
