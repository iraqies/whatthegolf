using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentity
{
	public class AmazonCognitoIdentityException : AmazonServiceException
	{
		public AmazonCognitoIdentityException(string message)
		{
		}

		public AmazonCognitoIdentityException(string message, Exception innerException)
		{
		}

		public AmazonCognitoIdentityException(Exception innerException)
		{
		}

		public AmazonCognitoIdentityException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public AmazonCognitoIdentityException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
