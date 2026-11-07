using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class InvalidOAuthFlowException : AmazonCognitoIdentityProviderException
	{
		public InvalidOAuthFlowException(string message)
			: base((string)null)
		{
		}

		public InvalidOAuthFlowException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidOAuthFlowException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidOAuthFlowException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidOAuthFlowException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
