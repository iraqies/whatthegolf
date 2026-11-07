using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UserNotConfirmedException : AmazonCognitoIdentityProviderException
	{
		public UserNotConfirmedException(string message)
			: base((string)null)
		{
		}

		public UserNotConfirmedException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public UserNotConfirmedException(Exception innerException)
			: base((string)null)
		{
		}

		public UserNotConfirmedException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public UserNotConfirmedException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
