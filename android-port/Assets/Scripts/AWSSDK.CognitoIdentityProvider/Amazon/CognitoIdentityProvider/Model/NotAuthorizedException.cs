using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class NotAuthorizedException : AmazonCognitoIdentityProviderException
	{
		public NotAuthorizedException(string message)
			: base((string)null)
		{
		}

		public NotAuthorizedException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public NotAuthorizedException(Exception innerException)
			: base((string)null)
		{
		}

		public NotAuthorizedException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public NotAuthorizedException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
