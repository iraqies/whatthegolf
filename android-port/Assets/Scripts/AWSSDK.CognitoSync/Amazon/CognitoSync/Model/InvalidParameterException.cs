using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000025")]
	public class InvalidParameterException : AmazonCognitoSyncException
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x119DB80", Offset = "0x119DB80", VA = "0x119DB80")]
		public InvalidParameterException(string message)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x119DB88", Offset = "0x119DB88", VA = "0x119DB88")]
		public InvalidParameterException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x119DB90", Offset = "0x119DB90", VA = "0x119DB90")]
		public InvalidParameterException(Exception innerException)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x119DBD8", Offset = "0x119DBD8", VA = "0x119DBD8")]
		public InvalidParameterException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x119DBE0", Offset = "0x119DBE0", VA = "0x119DBE0")]
		public InvalidParameterException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
