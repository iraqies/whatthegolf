using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000073")]
	public class ConcurrentModificationException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x10E4944", Offset = "0x10E4944", VA = "0x10E4944")]
		public ConcurrentModificationException(string message)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x10E494C", Offset = "0x10E494C", VA = "0x10E494C")]
		public ConcurrentModificationException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x10E4954", Offset = "0x10E4954", VA = "0x10E4954")]
		public ConcurrentModificationException(Exception innerException)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x10E499C", Offset = "0x10E499C", VA = "0x10E499C")]
		public ConcurrentModificationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x10E49A4", Offset = "0x10E49A4", VA = "0x10E49A4")]
		public ConcurrentModificationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
