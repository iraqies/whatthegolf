using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000034")]
	public class ResourceConflictException : AmazonCognitoSyncException
	{
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x11A7080", Offset = "0x11A7080", VA = "0x11A7080")]
		public ResourceConflictException(string message)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x11A7088", Offset = "0x11A7088", VA = "0x11A7088")]
		public ResourceConflictException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x11A7090", Offset = "0x11A7090", VA = "0x11A7090")]
		public ResourceConflictException(Exception innerException)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x11A70D8", Offset = "0x11A70D8", VA = "0x11A70D8")]
		public ResourceConflictException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x11A70E0", Offset = "0x11A70E0", VA = "0x11A70E0")]
		public ResourceConflictException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
