using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync
{
	[Token(Token = "0x2000003")]
	public class AmazonCognitoSyncException : AmazonServiceException
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x118C2B4", Offset = "0x118C2B4", VA = "0x118C2B4")]
		public AmazonCognitoSyncException(string message)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x118C2C4", Offset = "0x118C2C4", VA = "0x118C2C4")]
		public AmazonCognitoSyncException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x118C314", Offset = "0x118C314", VA = "0x118C314")]
		public AmazonCognitoSyncException(Exception innerException)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x118C374", Offset = "0x118C374", VA = "0x118C374")]
		public AmazonCognitoSyncException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x118C364", Offset = "0x118C364", VA = "0x118C364")]
		public AmazonCognitoSyncException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
