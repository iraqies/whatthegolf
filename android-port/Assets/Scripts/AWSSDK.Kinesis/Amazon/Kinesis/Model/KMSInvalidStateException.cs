using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000032")]
	public class KMSInvalidStateException : AmazonKinesisException
	{
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x12B5D84", Offset = "0x12B5D84", VA = "0x12B5D84")]
		public KMSInvalidStateException(string message)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x12B5D8C", Offset = "0x12B5D8C", VA = "0x12B5D8C")]
		public KMSInvalidStateException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x12B5D94", Offset = "0x12B5D94", VA = "0x12B5D94")]
		public KMSInvalidStateException(Exception innerException)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x12B5DDC", Offset = "0x12B5DDC", VA = "0x12B5DDC")]
		public KMSInvalidStateException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x12B5DE4", Offset = "0x12B5DE4", VA = "0x12B5DE4")]
		public KMSInvalidStateException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
