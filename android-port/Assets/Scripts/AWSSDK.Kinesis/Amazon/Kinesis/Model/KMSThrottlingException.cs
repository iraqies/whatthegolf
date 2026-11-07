using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000035")]
	public class KMSThrottlingException : AmazonKinesisException
	{
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x12B6258", Offset = "0x12B6258", VA = "0x12B6258")]
		public KMSThrottlingException(string message)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x12B6260", Offset = "0x12B6260", VA = "0x12B6260")]
		public KMSThrottlingException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x12B6268", Offset = "0x12B6268", VA = "0x12B6268")]
		public KMSThrottlingException(Exception innerException)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x12B62B0", Offset = "0x12B62B0", VA = "0x12B62B0")]
		public KMSThrottlingException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x12B62B8", Offset = "0x12B62B8", VA = "0x12B62B8")]
		public KMSThrottlingException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
