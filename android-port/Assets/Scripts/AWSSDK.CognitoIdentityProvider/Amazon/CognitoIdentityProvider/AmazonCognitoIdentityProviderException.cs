using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class AmazonCognitoIdentityProviderException : AmazonServiceException
	{
		public AmazonCognitoIdentityProviderException(string message)
		{
		}

		public AmazonCognitoIdentityProviderException(string message, Exception innerException)
		{
		}

		public AmazonCognitoIdentityProviderException(Exception innerException)
		{
		}

		public AmazonCognitoIdentityProviderException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public AmazonCognitoIdentityProviderException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
