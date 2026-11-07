using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200006F")]
	public class CodeDeliveryFailureException : AmazonCognitoIdentityProviderException
	{
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x10E3404", Offset = "0x10E3404", VA = "0x10E3404")]
		public CodeDeliveryFailureException(string message)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x10E340C", Offset = "0x10E340C", VA = "0x10E340C")]
		public CodeDeliveryFailureException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x10E3414", Offset = "0x10E3414", VA = "0x10E3414")]
		public CodeDeliveryFailureException(Exception innerException)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x10E345C", Offset = "0x10E345C", VA = "0x10E345C")]
		public CodeDeliveryFailureException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x10E3464", Offset = "0x10E3464", VA = "0x10E3464")]
		public CodeDeliveryFailureException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
