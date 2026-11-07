using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000033")]
	public class KMSNotFoundException : AmazonKinesisException
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x12B5F20", Offset = "0x12B5F20", VA = "0x12B5F20")]
		public KMSNotFoundException(string message)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x12B5F28", Offset = "0x12B5F28", VA = "0x12B5F28")]
		public KMSNotFoundException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x12B5F30", Offset = "0x12B5F30", VA = "0x12B5F30")]
		public KMSNotFoundException(Exception innerException)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x12B5F78", Offset = "0x12B5F78", VA = "0x12B5F78")]
		public KMSNotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x12B5F80", Offset = "0x12B5F80", VA = "0x12B5F80")]
		public KMSNotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
