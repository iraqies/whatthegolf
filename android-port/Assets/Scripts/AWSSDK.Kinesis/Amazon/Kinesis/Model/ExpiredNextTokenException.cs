using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000027")]
	public class ExpiredNextTokenException : AmazonKinesisException
	{
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x12B0320", Offset = "0x12B0320", VA = "0x12B0320")]
		public ExpiredNextTokenException(string message)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x12B0328", Offset = "0x12B0328", VA = "0x12B0328")]
		public ExpiredNextTokenException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x12B0330", Offset = "0x12B0330", VA = "0x12B0330")]
		public ExpiredNextTokenException(Exception innerException)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x12B0378", Offset = "0x12B0378", VA = "0x12B0378")]
		public ExpiredNextTokenException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x12B0380", Offset = "0x12B0380", VA = "0x12B0380")]
		public ExpiredNextTokenException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
