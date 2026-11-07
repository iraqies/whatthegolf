using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000F1")]
	public class MFAMethodNotFoundException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x113CBF0", Offset = "0x113CBF0", VA = "0x113CBF0")]
		public MFAMethodNotFoundException(string message)
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x113CBF8", Offset = "0x113CBF8", VA = "0x113CBF8")]
		public MFAMethodNotFoundException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x113CC00", Offset = "0x113CC00", VA = "0x113CC00")]
		public MFAMethodNotFoundException(Exception innerException)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x113CC08", Offset = "0x113CC08", VA = "0x113CC08")]
		public MFAMethodNotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x113CC10", Offset = "0x113CC10", VA = "0x113CC10")]
		public MFAMethodNotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
