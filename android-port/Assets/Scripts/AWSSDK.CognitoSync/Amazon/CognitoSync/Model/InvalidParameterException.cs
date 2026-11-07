using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class InvalidParameterException : AmazonCognitoSyncException
	{
		public InvalidParameterException(string message)
			: base((string)null)
		{
		}

		public InvalidParameterException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidParameterException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidParameterException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidParameterException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
