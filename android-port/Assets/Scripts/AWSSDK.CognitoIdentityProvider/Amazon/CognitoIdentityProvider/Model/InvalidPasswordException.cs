using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class InvalidPasswordException : AmazonCognitoIdentityProviderException
	{
		public InvalidPasswordException(string message)
			: base((string)null)
		{
		}

		public InvalidPasswordException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidPasswordException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidPasswordException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidPasswordException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
