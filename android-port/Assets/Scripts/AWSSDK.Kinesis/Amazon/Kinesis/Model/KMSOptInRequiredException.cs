using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000034")]
	public class KMSOptInRequiredException : AmazonKinesisException
	{
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x12B60BC", Offset = "0x12B60BC", VA = "0x12B60BC")]
		public KMSOptInRequiredException(string message)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x12B60C4", Offset = "0x12B60C4", VA = "0x12B60C4")]
		public KMSOptInRequiredException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x12B60CC", Offset = "0x12B60CC", VA = "0x12B60CC")]
		public KMSOptInRequiredException(Exception innerException)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x12B6114", Offset = "0x12B6114", VA = "0x12B6114")]
		public KMSOptInRequiredException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x12B611C", Offset = "0x12B611C", VA = "0x12B611C")]
		public KMSOptInRequiredException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
