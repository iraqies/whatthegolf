using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class InvalidLambdaResponseException : AmazonCognitoIdentityProviderException
	{
		public InvalidLambdaResponseException(string message)
			: base((string)null)
		{
		}

		public InvalidLambdaResponseException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidLambdaResponseException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidLambdaResponseException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidLambdaResponseException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
