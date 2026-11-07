using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200004D")]
	public class TooManyRequestsException : AmazonCognitoIdentityException
	{
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x11819EC", Offset = "0x11819EC", VA = "0x11819EC")]
		public TooManyRequestsException(string message)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x11819F4", Offset = "0x11819F4", VA = "0x11819F4")]
		public TooManyRequestsException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x11819FC", Offset = "0x11819FC", VA = "0x11819FC")]
		public TooManyRequestsException(Exception innerException)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1181A04", Offset = "0x1181A04", VA = "0x1181A04")]
		public TooManyRequestsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1181A0C", Offset = "0x1181A0C", VA = "0x1181A0C")]
		public TooManyRequestsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
