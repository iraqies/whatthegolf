using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class PasswordResetRequiredException : AmazonCognitoIdentityProviderException
	{
		public PasswordResetRequiredException(string message)
			: base((string)null)
		{
		}

		public PasswordResetRequiredException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public PasswordResetRequiredException(Exception innerException)
			: base((string)null)
		{
		}

		public PasswordResetRequiredException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public PasswordResetRequiredException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
