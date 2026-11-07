using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class InvalidConfigurationException : AmazonCognitoSyncException
	{
		public InvalidConfigurationException(string message)
			: base((string)null)
		{
		}

		public InvalidConfigurationException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidConfigurationException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidConfigurationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidConfigurationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
