using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000063")]
	public class AliasExistsException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x10C756C", Offset = "0x10C756C", VA = "0x10C756C")]
		public AliasExistsException(string message)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x10C757C", Offset = "0x10C757C", VA = "0x10C757C")]
		public AliasExistsException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x10C758C", Offset = "0x10C758C", VA = "0x10C758C")]
		public AliasExistsException(Exception innerException)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x10C761C", Offset = "0x10C761C", VA = "0x10C761C")]
		public AliasExistsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x10C7624", Offset = "0x10C7624", VA = "0x10C7624")]
		public AliasExistsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
