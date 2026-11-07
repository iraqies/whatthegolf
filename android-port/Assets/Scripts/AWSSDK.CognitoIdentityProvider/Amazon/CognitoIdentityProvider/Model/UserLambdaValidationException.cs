using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200013F")]
	public class UserLambdaValidationException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x1173134", Offset = "0x1173134", VA = "0x1173134")]
		public UserLambdaValidationException(string message)
		{
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x117313C", Offset = "0x117313C", VA = "0x117313C")]
		public UserLambdaValidationException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x1173144", Offset = "0x1173144", VA = "0x1173144")]
		public UserLambdaValidationException(Exception innerException)
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x117314C", Offset = "0x117314C", VA = "0x117314C")]
		public UserLambdaValidationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x1173154", Offset = "0x1173154", VA = "0x1173154")]
		public UserLambdaValidationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
