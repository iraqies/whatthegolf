using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200000F")]
	public class ConcurrentModificationException : AmazonCognitoSyncException
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1192CF8", Offset = "0x1192CF8", VA = "0x1192CF8")]
		public ConcurrentModificationException(string message)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1192D00", Offset = "0x1192D00", VA = "0x1192D00")]
		public ConcurrentModificationException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1192D08", Offset = "0x1192D08", VA = "0x1192D08")]
		public ConcurrentModificationException(Exception innerException)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1192D50", Offset = "0x1192D50", VA = "0x1192D50")]
		public ConcurrentModificationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1192D58", Offset = "0x1192D58", VA = "0x1192D58")]
		public ConcurrentModificationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
