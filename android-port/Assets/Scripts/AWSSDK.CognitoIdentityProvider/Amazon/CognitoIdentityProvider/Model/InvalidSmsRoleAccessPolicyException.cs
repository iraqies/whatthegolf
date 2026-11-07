using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000D7")]
	public class InvalidSmsRoleAccessPolicyException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x112BAF0", Offset = "0x112BAF0", VA = "0x112BAF0")]
		public InvalidSmsRoleAccessPolicyException(string message)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x112BAF8", Offset = "0x112BAF8", VA = "0x112BAF8")]
		public InvalidSmsRoleAccessPolicyException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x112BB00", Offset = "0x112BB00", VA = "0x112BB00")]
		public InvalidSmsRoleAccessPolicyException(Exception innerException)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x112BB08", Offset = "0x112BB08", VA = "0x112BB08")]
		public InvalidSmsRoleAccessPolicyException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x112BB10", Offset = "0x112BB10", VA = "0x112BB10")]
		public InvalidSmsRoleAccessPolicyException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
