using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x200001F")]
	public class ExpiredTokenException : AmazonSecurityTokenServiceException
	{
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x12DE498", Offset = "0x12DE498", VA = "0x12DE498")]
		public ExpiredTokenException(string message)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x12DE4A0", Offset = "0x12DE4A0", VA = "0x12DE4A0")]
		public ExpiredTokenException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x12DE4A8", Offset = "0x12DE4A8", VA = "0x12DE4A8")]
		public ExpiredTokenException(Exception innerException)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x12DE4F0", Offset = "0x12DE4F0", VA = "0x12DE4F0")]
		public ExpiredTokenException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x12DE4F8", Offset = "0x12DE4F8", VA = "0x12DE4F8")]
		public ExpiredTokenException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
