using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken
{
	[Token(Token = "0x200000B")]
	public class AmazonSecurityTokenServiceException : AmazonServiceException
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x12D4F6C", Offset = "0x12D4F6C", VA = "0x12D4F6C")]
		public AmazonSecurityTokenServiceException(string message)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x12D4F74", Offset = "0x12D4F74", VA = "0x12D4F74")]
		public AmazonSecurityTokenServiceException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x12D4F7C", Offset = "0x12D4F7C", VA = "0x12D4F7C")]
		public AmazonSecurityTokenServiceException(Exception innerException)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x12D4FC4", Offset = "0x12D4FC4", VA = "0x12D4FC4")]
		public AmazonSecurityTokenServiceException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x12D4FCC", Offset = "0x12D4FCC", VA = "0x12D4FCC")]
		public AmazonSecurityTokenServiceException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
