using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000127")]
	public class UnsupportedUserStateException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x115DA60", Offset = "0x115DA60", VA = "0x115DA60")]
		public UnsupportedUserStateException(string message)
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x115DA68", Offset = "0x115DA68", VA = "0x115DA68")]
		public UnsupportedUserStateException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x115DA70", Offset = "0x115DA70", VA = "0x115DA70")]
		public UnsupportedUserStateException(Exception innerException)
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x115DA78", Offset = "0x115DA78", VA = "0x115DA78")]
		public UnsupportedUserStateException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x115DA80", Offset = "0x115DA80", VA = "0x115DA80")]
		public UnsupportedUserStateException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
