using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class ResourceConflictException : AmazonCognitoSyncException
	{
		public ResourceConflictException(string message)
			: base((string)null)
		{
		}

		public ResourceConflictException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public ResourceConflictException(Exception innerException)
			: base((string)null)
		{
		}

		public ResourceConflictException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public ResourceConflictException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
