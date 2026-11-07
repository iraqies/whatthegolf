using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class InvalidLambdaFunctionOutputException : AmazonCognitoSyncException
	{
		public InvalidLambdaFunctionOutputException(string message)
			: base((string)null)
		{
		}

		public InvalidLambdaFunctionOutputException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidLambdaFunctionOutputException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidLambdaFunctionOutputException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidLambdaFunctionOutputException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
