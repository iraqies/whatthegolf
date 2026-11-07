using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000123")]
	public class TooManyRequestsException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x115CAEC", Offset = "0x115CAEC", VA = "0x115CAEC")]
		public TooManyRequestsException(string message)
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x115CAF4", Offset = "0x115CAF4", VA = "0x115CAF4")]
		public TooManyRequestsException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x115CAFC", Offset = "0x115CAFC", VA = "0x115CAFC")]
		public TooManyRequestsException(Exception innerException)
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x115CB04", Offset = "0x115CB04", VA = "0x115CB04")]
		public TooManyRequestsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x115CB0C", Offset = "0x115CB0C", VA = "0x115CB0C")]
		public TooManyRequestsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
