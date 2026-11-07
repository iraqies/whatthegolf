using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class TooManyRequestsException : AmazonCognitoIdentityProviderException
	{
		public TooManyRequestsException(string message)
			: base((string)null)
		{
		}

		public TooManyRequestsException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public TooManyRequestsException(Exception innerException)
			: base((string)null)
		{
		}

		public TooManyRequestsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public TooManyRequestsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
