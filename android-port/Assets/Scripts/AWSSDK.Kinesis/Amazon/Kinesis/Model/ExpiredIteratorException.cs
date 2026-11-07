using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000026")]
	public class ExpiredIteratorException : AmazonKinesisException
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x12B00A0", Offset = "0x12B00A0", VA = "0x12B00A0")]
		public ExpiredIteratorException(string message)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x12B00A8", Offset = "0x12B00A8", VA = "0x12B00A8")]
		public ExpiredIteratorException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x12B00B0", Offset = "0x12B00B0", VA = "0x12B00B0")]
		public ExpiredIteratorException(Exception innerException)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x12B00F8", Offset = "0x12B00F8", VA = "0x12B00F8")]
		public ExpiredIteratorException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x12B0100", Offset = "0x12B0100", VA = "0x12B0100")]
		public ExpiredIteratorException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
