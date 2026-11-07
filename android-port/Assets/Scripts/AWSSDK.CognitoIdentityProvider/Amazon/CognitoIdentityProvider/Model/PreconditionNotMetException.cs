using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000FA")]
	public class PreconditionNotMetException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x1140E38", Offset = "0x1140E38", VA = "0x1140E38")]
		public PreconditionNotMetException(string message)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x1140E40", Offset = "0x1140E40", VA = "0x1140E40")]
		public PreconditionNotMetException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x1140E48", Offset = "0x1140E48", VA = "0x1140E48")]
		public PreconditionNotMetException(Exception innerException)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x1140E50", Offset = "0x1140E50", VA = "0x1140E50")]
		public PreconditionNotMetException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x1140E58", Offset = "0x1140E58", VA = "0x1140E58")]
		public PreconditionNotMetException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
