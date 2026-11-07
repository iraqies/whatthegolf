using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class InternalErrorException : AmazonCognitoSyncException
	{
		public InternalErrorException(string message)
			: base((string)null)
		{
		}

		public InternalErrorException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InternalErrorException(Exception innerException)
			: base((string)null)
		{
		}

		public InternalErrorException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InternalErrorException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
