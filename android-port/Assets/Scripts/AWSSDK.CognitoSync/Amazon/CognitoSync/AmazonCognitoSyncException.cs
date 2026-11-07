using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoSync
{
	public class AmazonCognitoSyncException : AmazonServiceException
	{
		public AmazonCognitoSyncException(string message)
		{
		}

		public AmazonCognitoSyncException(string message, Exception innerException)
		{
		}

		public AmazonCognitoSyncException(Exception innerException)
		{
		}

		public AmazonCognitoSyncException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public AmazonCognitoSyncException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
