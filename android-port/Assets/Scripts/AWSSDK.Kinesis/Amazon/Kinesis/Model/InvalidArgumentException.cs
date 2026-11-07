using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200002F")]
	public class InvalidArgumentException : AmazonKinesisException
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x12B58B0", Offset = "0x12B58B0", VA = "0x12B58B0")]
		public InvalidArgumentException(string message)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x12B58B8", Offset = "0x12B58B8", VA = "0x12B58B8")]
		public InvalidArgumentException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x12B58C0", Offset = "0x12B58C0", VA = "0x12B58C0")]
		public InvalidArgumentException(Exception innerException)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x12B5908", Offset = "0x12B5908", VA = "0x12B5908")]
		public InvalidArgumentException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x12B5910", Offset = "0x12B5910", VA = "0x12B5910")]
		public InvalidArgumentException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
