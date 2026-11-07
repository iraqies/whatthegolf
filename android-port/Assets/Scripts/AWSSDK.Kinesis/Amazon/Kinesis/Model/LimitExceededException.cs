using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000036")]
	public class LimitExceededException : AmazonKinesisException
	{
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x12B63F4", Offset = "0x12B63F4", VA = "0x12B63F4")]
		public LimitExceededException(string message)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x12B63FC", Offset = "0x12B63FC", VA = "0x12B63FC")]
		public LimitExceededException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x12B6404", Offset = "0x12B6404", VA = "0x12B6404")]
		public LimitExceededException(Exception innerException)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x12B644C", Offset = "0x12B644C", VA = "0x12B644C")]
		public LimitExceededException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x12B6454", Offset = "0x12B6454", VA = "0x12B6454")]
		public LimitExceededException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
