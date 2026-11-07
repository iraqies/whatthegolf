using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UserNotFoundException : AmazonCognitoIdentityProviderException
	{
		public UserNotFoundException(string message)
			: base((string)null)
		{
		}

		public UserNotFoundException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public UserNotFoundException(Exception innerException)
			: base((string)null)
		{
		}

		public UserNotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public UserNotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
