using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis
{
	[Token(Token = "0x2000003")]
	public class AmazonKinesisException : AmazonServiceException
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x12A1A10", Offset = "0x12A1A10", VA = "0x12A1A10")]
		public AmazonKinesisException(string message)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x12A1A18", Offset = "0x12A1A18", VA = "0x12A1A18")]
		public AmazonKinesisException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x12A1A20", Offset = "0x12A1A20", VA = "0x12A1A20")]
		public AmazonKinesisException(Exception innerException)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x12A1A68", Offset = "0x12A1A68", VA = "0x12A1A68")]
		public AmazonKinesisException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x129B598", Offset = "0x129B598", VA = "0x129B598")]
		public AmazonKinesisException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
