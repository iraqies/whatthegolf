using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000D3")]
	public class InvalidLambdaResponseException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x112B3B8", Offset = "0x112B3B8", VA = "0x112B3B8")]
		public InvalidLambdaResponseException(string message)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x112B3C0", Offset = "0x112B3C0", VA = "0x112B3C0")]
		public InvalidLambdaResponseException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x112B3C8", Offset = "0x112B3C8", VA = "0x112B3C8")]
		public InvalidLambdaResponseException(Exception innerException)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x112B3D0", Offset = "0x112B3D0", VA = "0x112B3D0")]
		public InvalidLambdaResponseException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x112B3D8", Offset = "0x112B3D8", VA = "0x112B3D8")]
		public InvalidLambdaResponseException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
