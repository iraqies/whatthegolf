using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200004E")]
	public class ResourceNotFoundException : AmazonKinesisException
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x12C5D98", Offset = "0x12C5D98", VA = "0x12C5D98")]
		public ResourceNotFoundException(string message)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x12C5DA0", Offset = "0x12C5DA0", VA = "0x12C5DA0")]
		public ResourceNotFoundException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x12C5DA8", Offset = "0x12C5DA8", VA = "0x12C5DA8")]
		public ResourceNotFoundException(Exception innerException)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x12C5DB0", Offset = "0x12C5DB0", VA = "0x12C5DB0")]
		public ResourceNotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x12C5DB8", Offset = "0x12C5DB8", VA = "0x12C5DB8")]
		public ResourceNotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
