using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200014A")]
	public class UserPoolTaggingException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x1175A00", Offset = "0x1175A00", VA = "0x1175A00")]
		public UserPoolTaggingException(string message)
		{
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x1175A08", Offset = "0x1175A08", VA = "0x1175A08")]
		public UserPoolTaggingException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x1175A10", Offset = "0x1175A10", VA = "0x1175A10")]
		public UserPoolTaggingException(Exception innerException)
		{
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x1175A18", Offset = "0x1175A18", VA = "0x1175A18")]
		public UserPoolTaggingException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x1175A20", Offset = "0x1175A20", VA = "0x1175A20")]
		public UserPoolTaggingException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
