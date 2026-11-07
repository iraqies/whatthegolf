using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200001C")]
	public class ConcurrentModificationException : AmazonCognitoIdentityException
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1078D00", Offset = "0x1078D00", VA = "0x1078D00")]
		public ConcurrentModificationException(string message)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1078D08", Offset = "0x1078D08", VA = "0x1078D08")]
		public ConcurrentModificationException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1078D10", Offset = "0x1078D10", VA = "0x1078D10")]
		public ConcurrentModificationException(Exception innerException)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1078D58", Offset = "0x1078D58", VA = "0x1078D58")]
		public ConcurrentModificationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1078D60", Offset = "0x1078D60", VA = "0x1078D60")]
		public ConcurrentModificationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
