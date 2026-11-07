using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class InvalidUserPoolConfigurationException : AmazonCognitoIdentityProviderException
	{
		public InvalidUserPoolConfigurationException(string message)
			: base((string)null)
		{
		}

		public InvalidUserPoolConfigurationException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidUserPoolConfigurationException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidUserPoolConfigurationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidUserPoolConfigurationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
