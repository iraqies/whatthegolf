using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UnexpectedLambdaException : AmazonCognitoIdentityProviderException
	{
		public UnexpectedLambdaException(string message)
			: base((string)null)
		{
		}

		public UnexpectedLambdaException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public UnexpectedLambdaException(Exception innerException)
			: base((string)null)
		{
		}

		public UnexpectedLambdaException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public UnexpectedLambdaException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
