using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x200002D")]
	public class MalformedPolicyDocumentException : AmazonSecurityTokenServiceException
	{
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x12E4080", Offset = "0x12E4080", VA = "0x12E4080")]
		public MalformedPolicyDocumentException(string message)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x12E4088", Offset = "0x12E4088", VA = "0x12E4088")]
		public MalformedPolicyDocumentException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x12E4090", Offset = "0x12E4090", VA = "0x12E4090")]
		public MalformedPolicyDocumentException(Exception innerException)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x12E40D8", Offset = "0x12E40D8", VA = "0x12E40D8")]
		public MalformedPolicyDocumentException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x12E40E0", Offset = "0x12E40E0", VA = "0x12E40E0")]
		public MalformedPolicyDocumentException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
