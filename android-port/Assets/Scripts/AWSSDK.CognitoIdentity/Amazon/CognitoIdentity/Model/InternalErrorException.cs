using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000035")]
	public class InternalErrorException : AmazonCognitoIdentityException
	{
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x108D2AC", Offset = "0x108D2AC", VA = "0x108D2AC")]
		public InternalErrorException(string message)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x108D2B4", Offset = "0x108D2B4", VA = "0x108D2B4")]
		public InternalErrorException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x108D2BC", Offset = "0x108D2BC", VA = "0x108D2BC")]
		public InternalErrorException(Exception innerException)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x108D304", Offset = "0x108D304", VA = "0x108D304")]
		public InternalErrorException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x108D30C", Offset = "0x108D30C", VA = "0x108D30C")]
		public InternalErrorException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
