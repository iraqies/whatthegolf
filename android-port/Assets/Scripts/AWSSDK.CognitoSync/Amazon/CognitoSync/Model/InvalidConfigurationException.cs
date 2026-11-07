using System;
using System.Net;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000023")]
	public class InvalidConfigurationException : AmazonCognitoSyncException
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x119D680", Offset = "0x119D680", VA = "0x119D680")]
		public InvalidConfigurationException(string message)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x119D688", Offset = "0x119D688", VA = "0x119D688")]
		public InvalidConfigurationException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x119D690", Offset = "0x119D690", VA = "0x119D690")]
		public InvalidConfigurationException(Exception innerException)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x119D6D8", Offset = "0x119D6D8", VA = "0x119D6D8")]
		public InvalidConfigurationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x119D6E0", Offset = "0x119D6E0", VA = "0x119D6E0")]
		public InvalidConfigurationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
