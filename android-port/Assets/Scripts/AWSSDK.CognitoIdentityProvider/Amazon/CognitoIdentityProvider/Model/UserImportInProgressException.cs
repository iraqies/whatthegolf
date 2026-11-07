using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200013D")]
	public class UserImportInProgressException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x1172204", Offset = "0x1172204", VA = "0x1172204")]
		public UserImportInProgressException(string message)
		{
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x117220C", Offset = "0x117220C", VA = "0x117220C")]
		public UserImportInProgressException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x1172214", Offset = "0x1172214", VA = "0x1172214")]
		public UserImportInProgressException(Exception innerException)
		{
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x117221C", Offset = "0x117221C", VA = "0x117221C")]
		public UserImportInProgressException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x1172224", Offset = "0x1172224", VA = "0x1172224")]
		public UserImportInProgressException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
