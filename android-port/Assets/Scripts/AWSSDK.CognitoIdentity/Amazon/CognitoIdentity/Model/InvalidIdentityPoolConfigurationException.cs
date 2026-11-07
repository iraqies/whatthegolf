using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentity.Model
{
	public class InvalidIdentityPoolConfigurationException : AmazonCognitoIdentityException
	{
		public InvalidIdentityPoolConfigurationException(string message)
			: base((string)null)
		{
		}

		public InvalidIdentityPoolConfigurationException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidIdentityPoolConfigurationException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidIdentityPoolConfigurationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidIdentityPoolConfigurationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
