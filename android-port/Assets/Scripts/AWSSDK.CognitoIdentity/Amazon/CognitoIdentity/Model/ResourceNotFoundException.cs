using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000046")]
	public class ResourceNotFoundException : AmazonCognitoIdentityException
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1096504", Offset = "0x1096504", VA = "0x1096504")]
		public ResourceNotFoundException(string message)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x109650C", Offset = "0x109650C", VA = "0x109650C")]
		public ResourceNotFoundException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1096514", Offset = "0x1096514", VA = "0x1096514")]
		public ResourceNotFoundException(Exception innerException)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x109655C", Offset = "0x109655C", VA = "0x109655C")]
		public ResourceNotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1096564", Offset = "0x1096564", VA = "0x1096564")]
		public ResourceNotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
