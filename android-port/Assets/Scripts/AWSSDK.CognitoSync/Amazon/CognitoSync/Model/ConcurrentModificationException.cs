using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class ConcurrentModificationException : AmazonCognitoSyncException
	{
		public ConcurrentModificationException(string message)
			: base((string)null)
		{
		}

		public ConcurrentModificationException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public ConcurrentModificationException(Exception innerException)
			: base((string)null)
		{
		}

		public ConcurrentModificationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public ConcurrentModificationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
