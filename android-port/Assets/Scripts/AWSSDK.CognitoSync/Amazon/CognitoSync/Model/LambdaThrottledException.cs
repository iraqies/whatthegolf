using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000026")]
	public class LambdaThrottledException : AmazonCognitoSyncException
	{
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x119DD1C", Offset = "0x119DD1C", VA = "0x119DD1C")]
		public LambdaThrottledException(string message)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x119DD24", Offset = "0x119DD24", VA = "0x119DD24")]
		public LambdaThrottledException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x119DD2C", Offset = "0x119DD2C", VA = "0x119DD2C")]
		public LambdaThrottledException(Exception innerException)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x119DD74", Offset = "0x119DD74", VA = "0x119DD74")]
		public LambdaThrottledException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x119DD7C", Offset = "0x119DD7C", VA = "0x119DD7C")]
		public LambdaThrottledException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
