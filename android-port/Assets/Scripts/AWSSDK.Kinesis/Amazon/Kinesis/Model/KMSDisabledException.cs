using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000031")]
	public class KMSDisabledException : AmazonKinesisException
	{
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x12B5BE8", Offset = "0x12B5BE8", VA = "0x12B5BE8")]
		public KMSDisabledException(string message)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x12B5BF0", Offset = "0x12B5BF0", VA = "0x12B5BF0")]
		public KMSDisabledException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x12B5BF8", Offset = "0x12B5BF8", VA = "0x12B5BF8")]
		public KMSDisabledException(Exception innerException)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x12B5C40", Offset = "0x12B5C40", VA = "0x12B5C40")]
		public KMSDisabledException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x12B5C48", Offset = "0x12B5C48", VA = "0x12B5C48")]
		public KMSDisabledException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
