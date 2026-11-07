using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000036")]
	public class InvalidIdentityPoolConfigurationException : AmazonCognitoIdentityException
	{
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x108D448", Offset = "0x108D448", VA = "0x108D448")]
		public InvalidIdentityPoolConfigurationException(string message)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x108D450", Offset = "0x108D450", VA = "0x108D450")]
		public InvalidIdentityPoolConfigurationException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x108D458", Offset = "0x108D458", VA = "0x108D458")]
		public InvalidIdentityPoolConfigurationException(Exception innerException)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x108D4A0", Offset = "0x108D4A0", VA = "0x108D4A0")]
		public InvalidIdentityPoolConfigurationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x108D4A8", Offset = "0x108D4A8", VA = "0x108D4A8")]
		public InvalidIdentityPoolConfigurationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
