using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000045")]
	public class ResourceConflictException : AmazonCognitoIdentityException
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1096368", Offset = "0x1096368", VA = "0x1096368")]
		public ResourceConflictException(string message)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1096370", Offset = "0x1096370", VA = "0x1096370")]
		public ResourceConflictException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1096378", Offset = "0x1096378", VA = "0x1096378")]
		public ResourceConflictException(Exception innerException)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x10963C0", Offset = "0x10963C0", VA = "0x10963C0")]
		public ResourceConflictException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x10963C8", Offset = "0x10963C8", VA = "0x10963C8")]
		public ResourceConflictException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
