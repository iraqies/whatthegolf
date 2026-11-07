using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000D4")]
	public class InvalidOAuthFlowException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x112B514", Offset = "0x112B514", VA = "0x112B514")]
		public InvalidOAuthFlowException(string message)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x112B51C", Offset = "0x112B51C", VA = "0x112B51C")]
		public InvalidOAuthFlowException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x112B524", Offset = "0x112B524", VA = "0x112B524")]
		public InvalidOAuthFlowException(Exception innerException)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x112B52C", Offset = "0x112B52C", VA = "0x112B52C")]
		public InvalidOAuthFlowException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x112B534", Offset = "0x112B534", VA = "0x112B534")]
		public InvalidOAuthFlowException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
