using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity
{
	[Token(Token = "0x2000011")]
	public class AmazonCognitoIdentityException : AmazonServiceException
	{
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1075D80", Offset = "0x1075D80", VA = "0x1075D80")]
		public AmazonCognitoIdentityException(string message)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1075D88", Offset = "0x1075D88", VA = "0x1075D88")]
		public AmazonCognitoIdentityException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1075D90", Offset = "0x1075D90", VA = "0x1075D90")]
		public AmazonCognitoIdentityException(Exception innerException)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1075DD8", Offset = "0x1075DD8", VA = "0x1075DD8")]
		public AmazonCognitoIdentityException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1075DE0", Offset = "0x1075DE0", VA = "0x1075DE0")]
		public AmazonCognitoIdentityException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
