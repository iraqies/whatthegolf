using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x200002E")]
	public class PackedPolicyTooLargeException : AmazonSecurityTokenServiceException
	{
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x12E421C", Offset = "0x12E421C", VA = "0x12E421C")]
		public PackedPolicyTooLargeException(string message)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x12E4224", Offset = "0x12E4224", VA = "0x12E4224")]
		public PackedPolicyTooLargeException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x12E422C", Offset = "0x12E422C", VA = "0x12E422C")]
		public PackedPolicyTooLargeException(Exception innerException)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x12E4274", Offset = "0x12E4274", VA = "0x12E4274")]
		public PackedPolicyTooLargeException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x12E427C", Offset = "0x12E427C", VA = "0x12E427C")]
		public PackedPolicyTooLargeException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
