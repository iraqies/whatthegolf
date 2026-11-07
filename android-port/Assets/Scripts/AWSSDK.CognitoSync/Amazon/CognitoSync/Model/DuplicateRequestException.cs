using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class DuplicateRequestException : AmazonCognitoSyncException
	{
		public DuplicateRequestException(string message)
			: base((string)null)
		{
		}

		public DuplicateRequestException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public DuplicateRequestException(Exception innerException)
			: base((string)null)
		{
		}

		public DuplicateRequestException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public DuplicateRequestException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
