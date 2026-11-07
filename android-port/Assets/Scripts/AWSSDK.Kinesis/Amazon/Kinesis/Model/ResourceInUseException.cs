using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200004D")]
	public class ResourceInUseException : AmazonKinesisException
	{
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x12C5C3C", Offset = "0x12C5C3C", VA = "0x12C5C3C")]
		public ResourceInUseException(string message)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x12C5C44", Offset = "0x12C5C44", VA = "0x12C5C44")]
		public ResourceInUseException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x12C5C4C", Offset = "0x12C5C4C", VA = "0x12C5C4C")]
		public ResourceInUseException(Exception innerException)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x12C5C54", Offset = "0x12C5C54", VA = "0x12C5C54")]
		public ResourceInUseException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x12C5C5C", Offset = "0x12C5C5C", VA = "0x12C5C5C")]
		public ResourceInUseException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
