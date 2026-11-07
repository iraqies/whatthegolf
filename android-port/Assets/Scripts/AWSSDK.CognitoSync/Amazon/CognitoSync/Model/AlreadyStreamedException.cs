using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200000B")]
	public class AlreadyStreamedException : AmazonCognitoSyncException
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x118C2AC", Offset = "0x118C2AC", VA = "0x118C2AC")]
		public AlreadyStreamedException(string message)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x118C2BC", Offset = "0x118C2BC", VA = "0x118C2BC")]
		public AlreadyStreamedException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x118C2CC", Offset = "0x118C2CC", VA = "0x118C2CC")]
		public AlreadyStreamedException(Exception innerException)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x118C35C", Offset = "0x118C35C", VA = "0x118C35C")]
		public AlreadyStreamedException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x118C36C", Offset = "0x118C36C", VA = "0x118C36C")]
		public AlreadyStreamedException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
