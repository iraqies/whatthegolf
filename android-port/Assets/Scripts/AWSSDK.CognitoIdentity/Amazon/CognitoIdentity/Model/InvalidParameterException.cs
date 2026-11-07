using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000037")]
	public class InvalidParameterException : AmazonCognitoIdentityException
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x108D5E4", Offset = "0x108D5E4", VA = "0x108D5E4")]
		public InvalidParameterException(string message)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x108D5EC", Offset = "0x108D5EC", VA = "0x108D5EC")]
		public InvalidParameterException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x108D5F4", Offset = "0x108D5F4", VA = "0x108D5F4")]
		public InvalidParameterException(Exception innerException)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x108D63C", Offset = "0x108D63C", VA = "0x108D63C")]
		public InvalidParameterException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x108D644", Offset = "0x108D644", VA = "0x108D644")]
		public InvalidParameterException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
