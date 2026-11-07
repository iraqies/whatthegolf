using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x200002C")]
	public class InvalidIdentityTokenException : AmazonSecurityTokenServiceException
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x12E3EE4", Offset = "0x12E3EE4", VA = "0x12E3EE4")]
		public InvalidIdentityTokenException(string message)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x12E3EEC", Offset = "0x12E3EEC", VA = "0x12E3EEC")]
		public InvalidIdentityTokenException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x12E3EF4", Offset = "0x12E3EF4", VA = "0x12E3EF4")]
		public InvalidIdentityTokenException(Exception innerException)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x12E3F3C", Offset = "0x12E3F3C", VA = "0x12E3F3C")]
		public InvalidIdentityTokenException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x12E3F44", Offset = "0x12E3F44", VA = "0x12E3F44")]
		public InvalidIdentityTokenException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
