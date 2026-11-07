using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000D2")]
	public class InvalidEmailRoleAccessPolicyException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x112B25C", Offset = "0x112B25C", VA = "0x112B25C")]
		public InvalidEmailRoleAccessPolicyException(string message)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x112B264", Offset = "0x112B264", VA = "0x112B264")]
		public InvalidEmailRoleAccessPolicyException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x112B26C", Offset = "0x112B26C", VA = "0x112B26C")]
		public InvalidEmailRoleAccessPolicyException(Exception innerException)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x112B274", Offset = "0x112B274", VA = "0x112B274")]
		public InvalidEmailRoleAccessPolicyException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x112B27C", Offset = "0x112B27C", VA = "0x112B27C")]
		public InvalidEmailRoleAccessPolicyException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
