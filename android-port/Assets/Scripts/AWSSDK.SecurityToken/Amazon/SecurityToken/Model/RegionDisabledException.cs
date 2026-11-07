using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000030")]
	public class RegionDisabledException : AmazonSecurityTokenServiceException
	{
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x12E43D0", Offset = "0x12E43D0", VA = "0x12E43D0")]
		public RegionDisabledException(string message)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x12E43D8", Offset = "0x12E43D8", VA = "0x12E43D8")]
		public RegionDisabledException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x12E43E0", Offset = "0x12E43E0", VA = "0x12E43E0")]
		public RegionDisabledException(Exception innerException)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x12E4428", Offset = "0x12E4428", VA = "0x12E4428")]
		public RegionDisabledException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x12E4430", Offset = "0x12E4430", VA = "0x12E4430")]
		public RegionDisabledException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
