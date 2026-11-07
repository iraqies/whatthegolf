using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UserLambdaValidationException : AmazonCognitoIdentityProviderException
	{
		public UserLambdaValidationException(string message)
			: base((string)null)
		{
		}

		public UserLambdaValidationException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public UserLambdaValidationException(Exception innerException)
			: base((string)null)
		{
		}

		public UserLambdaValidationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public UserLambdaValidationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
