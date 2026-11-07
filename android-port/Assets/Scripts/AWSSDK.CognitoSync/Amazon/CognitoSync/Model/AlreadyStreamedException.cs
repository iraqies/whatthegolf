using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class AlreadyStreamedException : AmazonCognitoSyncException
	{
		public AlreadyStreamedException(string message)
			: base((string)null)
		{
		}

		public AlreadyStreamedException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public AlreadyStreamedException(Exception innerException)
			: base((string)null)
		{
		}

		public AlreadyStreamedException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public AlreadyStreamedException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
