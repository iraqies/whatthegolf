using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000027")]
	public class DeveloperUserAlreadyRegisteredException : AmazonCognitoIdentityException
	{
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1083944", Offset = "0x1083944", VA = "0x1083944")]
		public DeveloperUserAlreadyRegisteredException(string message)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x108394C", Offset = "0x108394C", VA = "0x108394C")]
		public DeveloperUserAlreadyRegisteredException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1083954", Offset = "0x1083954", VA = "0x1083954")]
		public DeveloperUserAlreadyRegisteredException(Exception innerException)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x108399C", Offset = "0x108399C", VA = "0x108399C")]
		public DeveloperUserAlreadyRegisteredException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x10839A4", Offset = "0x10839A4", VA = "0x10839A4")]
		public DeveloperUserAlreadyRegisteredException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
