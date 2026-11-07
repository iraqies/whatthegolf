using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class TooManyFailedAttemptsException : AmazonCognitoIdentityProviderException
	{
		public TooManyFailedAttemptsException(string message)
			: base((string)null)
		{
		}

		public TooManyFailedAttemptsException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public TooManyFailedAttemptsException(Exception innerException)
			: base((string)null)
		{
		}

		public TooManyFailedAttemptsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public TooManyFailedAttemptsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
