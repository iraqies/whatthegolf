using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000044")]
	public class NotAuthorizedException : AmazonCognitoIdentityException
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x10961CC", Offset = "0x10961CC", VA = "0x10961CC")]
		public NotAuthorizedException(string message)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x10961D4", Offset = "0x10961D4", VA = "0x10961D4")]
		public NotAuthorizedException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x10961DC", Offset = "0x10961DC", VA = "0x10961DC")]
		public NotAuthorizedException(Exception innerException)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1096224", Offset = "0x1096224", VA = "0x1096224")]
		public NotAuthorizedException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x109622C", Offset = "0x109622C", VA = "0x109622C")]
		public NotAuthorizedException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
