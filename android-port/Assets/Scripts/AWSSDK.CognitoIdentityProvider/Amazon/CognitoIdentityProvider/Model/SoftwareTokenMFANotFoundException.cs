using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000119")]
	public class SoftwareTokenMFANotFoundException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x1156CDC", Offset = "0x1156CDC", VA = "0x1156CDC")]
		public SoftwareTokenMFANotFoundException(string message)
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x1156CE4", Offset = "0x1156CE4", VA = "0x1156CE4")]
		public SoftwareTokenMFANotFoundException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x1156CEC", Offset = "0x1156CEC", VA = "0x1156CEC")]
		public SoftwareTokenMFANotFoundException(Exception innerException)
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x1156CF4", Offset = "0x1156CF4", VA = "0x1156CF4")]
		public SoftwareTokenMFANotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x1156CFC", Offset = "0x1156CFC", VA = "0x1156CFC")]
		public SoftwareTokenMFANotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
