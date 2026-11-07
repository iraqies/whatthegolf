using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ExpiredCodeException : AmazonCognitoIdentityProviderException
	{
		public ExpiredCodeException(string message)
			: base((string)null)
		{
		}

		public ExpiredCodeException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public ExpiredCodeException(Exception innerException)
			: base((string)null)
		{
		}

		public ExpiredCodeException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public ExpiredCodeException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
