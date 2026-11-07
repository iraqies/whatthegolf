using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class LambdaThrottledException : AmazonCognitoSyncException
	{
		public LambdaThrottledException(string message)
			: base((string)null)
		{
		}

		public LambdaThrottledException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public LambdaThrottledException(Exception innerException)
			: base((string)null)
		{
		}

		public LambdaThrottledException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public LambdaThrottledException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
