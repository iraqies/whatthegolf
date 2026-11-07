using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000070")]
	public class CodeMismatchException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x10E3684", Offset = "0x10E3684", VA = "0x10E3684")]
		public CodeMismatchException(string message)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x10E368C", Offset = "0x10E368C", VA = "0x10E368C")]
		public CodeMismatchException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x10E3694", Offset = "0x10E3694", VA = "0x10E3694")]
		public CodeMismatchException(Exception innerException)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x10E36DC", Offset = "0x10E36DC", VA = "0x10E36DC")]
		public CodeMismatchException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x10E36E4", Offset = "0x10E36E4", VA = "0x10E36E4")]
		public CodeMismatchException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
