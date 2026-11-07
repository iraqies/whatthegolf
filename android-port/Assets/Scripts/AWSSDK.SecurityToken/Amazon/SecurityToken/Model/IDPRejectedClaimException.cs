using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x200002A")]
	public class IDPRejectedClaimException : AmazonSecurityTokenServiceException
	{
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x12E3BAC", Offset = "0x12E3BAC", VA = "0x12E3BAC")]
		public IDPRejectedClaimException(string message)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x12E3BB4", Offset = "0x12E3BB4", VA = "0x12E3BB4")]
		public IDPRejectedClaimException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x12E3BBC", Offset = "0x12E3BBC", VA = "0x12E3BBC")]
		public IDPRejectedClaimException(Exception innerException)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x12E3C04", Offset = "0x12E3C04", VA = "0x12E3C04")]
		public IDPRejectedClaimException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x12E3C0C", Offset = "0x12E3C0C", VA = "0x12E3C0C")]
		public IDPRejectedClaimException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
