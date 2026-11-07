using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000CB")]
	public class GroupExistsException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1127404", Offset = "0x1127404", VA = "0x1127404")]
		public GroupExistsException(string message)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x112740C", Offset = "0x112740C", VA = "0x112740C")]
		public GroupExistsException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1127414", Offset = "0x1127414", VA = "0x1127414")]
		public GroupExistsException(Exception innerException)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x112741C", Offset = "0x112741C", VA = "0x112741C")]
		public GroupExistsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1127424", Offset = "0x1127424", VA = "0x1127424")]
		public GroupExistsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
