using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000019")]
	public class DuplicateRequestException : AmazonCognitoSyncException
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1198DD0", Offset = "0x1198DD0", VA = "0x1198DD0")]
		public DuplicateRequestException(string message)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1198DD8", Offset = "0x1198DD8", VA = "0x1198DD8")]
		public DuplicateRequestException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1198DE0", Offset = "0x1198DE0", VA = "0x1198DE0")]
		public DuplicateRequestException(Exception innerException)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1198E28", Offset = "0x1198E28", VA = "0x1198E28")]
		public DuplicateRequestException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1198E30", Offset = "0x1198E30", VA = "0x1198E30")]
		public DuplicateRequestException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
