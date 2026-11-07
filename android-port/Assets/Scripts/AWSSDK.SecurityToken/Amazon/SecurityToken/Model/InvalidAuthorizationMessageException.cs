using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x200002B")]
	public class InvalidAuthorizationMessageException : AmazonSecurityTokenServiceException
	{
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x12E3D48", Offset = "0x12E3D48", VA = "0x12E3D48")]
		public InvalidAuthorizationMessageException(string message)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x12E3D50", Offset = "0x12E3D50", VA = "0x12E3D50")]
		public InvalidAuthorizationMessageException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x12E3D58", Offset = "0x12E3D58", VA = "0x12E3D58")]
		public InvalidAuthorizationMessageException(Exception innerException)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x12E3DA0", Offset = "0x12E3DA0", VA = "0x12E3DA0")]
		public InvalidAuthorizationMessageException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x12E3DA8", Offset = "0x12E3DA8", VA = "0x12E3DA8")]
		public InvalidAuthorizationMessageException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
