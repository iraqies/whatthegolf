using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000027")]
	public class LimitExceededException : AmazonCognitoSyncException
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x119DF9C", Offset = "0x119DF9C", VA = "0x119DF9C")]
		public LimitExceededException(string message)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x119DFA4", Offset = "0x119DFA4", VA = "0x119DFA4")]
		public LimitExceededException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x119DFAC", Offset = "0x119DFAC", VA = "0x119DFAC")]
		public LimitExceededException(Exception innerException)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x119DFF4", Offset = "0x119DFF4", VA = "0x119DFF4")]
		public LimitExceededException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x119DFFC", Offset = "0x119DFFC", VA = "0x119DFFC")]
		public LimitExceededException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
