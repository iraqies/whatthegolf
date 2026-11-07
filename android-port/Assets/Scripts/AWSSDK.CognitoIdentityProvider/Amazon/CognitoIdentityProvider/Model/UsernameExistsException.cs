using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000141")]
	public class UsernameExistsException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x1179AEC", Offset = "0x1179AEC", VA = "0x1179AEC")]
		public UsernameExistsException(string message)
		{
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x1179AF4", Offset = "0x1179AF4", VA = "0x1179AF4")]
		public UsernameExistsException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x1179AFC", Offset = "0x1179AFC", VA = "0x1179AFC")]
		public UsernameExistsException(Exception innerException)
		{
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x1179B04", Offset = "0x1179B04", VA = "0x1179B04")]
		public UsernameExistsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x1179B0C", Offset = "0x1179B0C", VA = "0x1179B0C")]
		public UsernameExistsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
