using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000024")]
	public class InvalidLambdaFunctionOutputException : AmazonCognitoSyncException
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x119D900", Offset = "0x119D900", VA = "0x119D900")]
		public InvalidLambdaFunctionOutputException(string message)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x119D908", Offset = "0x119D908", VA = "0x119D908")]
		public InvalidLambdaFunctionOutputException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x119D910", Offset = "0x119D910", VA = "0x119D910")]
		public InvalidLambdaFunctionOutputException(Exception innerException)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x119D958", Offset = "0x119D958", VA = "0x119D958")]
		public InvalidLambdaFunctionOutputException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x119D960", Offset = "0x119D960", VA = "0x119D960")]
		public InvalidLambdaFunctionOutputException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
