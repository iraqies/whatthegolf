using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000F4")]
	public class NotAuthorizedException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x113E110", Offset = "0x113E110", VA = "0x113E110")]
		public NotAuthorizedException(string message)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x113E118", Offset = "0x113E118", VA = "0x113E118")]
		public NotAuthorizedException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x113E120", Offset = "0x113E120", VA = "0x113E120")]
		public NotAuthorizedException(Exception innerException)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x113E128", Offset = "0x113E128", VA = "0x113E128")]
		public NotAuthorizedException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x113E130", Offset = "0x113E130", VA = "0x113E130")]
		public NotAuthorizedException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
