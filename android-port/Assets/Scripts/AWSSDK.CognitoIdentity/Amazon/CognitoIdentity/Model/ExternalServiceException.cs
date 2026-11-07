using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentity.Model
{
	public class ExternalServiceException : AmazonCognitoIdentityException
	{
		public ExternalServiceException(string message)
			: base((string)null)
		{
		}

		public ExternalServiceException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public ExternalServiceException(Exception innerException)
			: base((string)null)
		{
		}

		public ExternalServiceException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public ExternalServiceException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
