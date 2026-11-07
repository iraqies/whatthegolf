using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000041")]
	public class ProvisionedThroughputExceededException : AmazonKinesisException
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x12BE3F0", Offset = "0x12BE3F0", VA = "0x12BE3F0")]
		public ProvisionedThroughputExceededException(string message)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x12BE3F8", Offset = "0x12BE3F8", VA = "0x12BE3F8")]
		public ProvisionedThroughputExceededException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x12BE400", Offset = "0x12BE400", VA = "0x12BE400")]
		public ProvisionedThroughputExceededException(Exception innerException)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x12BE448", Offset = "0x12BE448", VA = "0x12BE448")]
		public ProvisionedThroughputExceededException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x12BE450", Offset = "0x12BE450", VA = "0x12BE450")]
		public ProvisionedThroughputExceededException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
