using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000035")]
	public class ResourceNotFoundException : AmazonCognitoSyncException
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x11A721C", Offset = "0x11A721C", VA = "0x11A721C")]
		public ResourceNotFoundException(string message)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x11A7224", Offset = "0x11A7224", VA = "0x11A7224")]
		public ResourceNotFoundException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x11A722C", Offset = "0x11A722C", VA = "0x11A722C")]
		public ResourceNotFoundException(Exception innerException)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x11A7274", Offset = "0x11A7274", VA = "0x11A7274")]
		public ResourceNotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x11A727C", Offset = "0x11A727C", VA = "0x11A727C")]
		public ResourceNotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
