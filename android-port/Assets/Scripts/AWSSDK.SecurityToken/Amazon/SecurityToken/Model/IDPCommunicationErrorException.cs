using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000029")]
	public class IDPCommunicationErrorException : AmazonSecurityTokenServiceException
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x12E3A10", Offset = "0x12E3A10", VA = "0x12E3A10")]
		public IDPCommunicationErrorException(string message)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x12E3A18", Offset = "0x12E3A18", VA = "0x12E3A18")]
		public IDPCommunicationErrorException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x12E3A20", Offset = "0x12E3A20", VA = "0x12E3A20")]
		public IDPCommunicationErrorException(Exception innerException)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x12E3A68", Offset = "0x12E3A68", VA = "0x12E3A68")]
		public IDPCommunicationErrorException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x12E3A70", Offset = "0x12E3A70", VA = "0x12E3A70")]
		public IDPCommunicationErrorException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
