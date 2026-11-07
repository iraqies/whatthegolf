using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentity.Model
{
	public class TooManyRequestsException : AmazonCognitoIdentityException
	{
		public TooManyRequestsException(string message)
			: base((string)null)
		{
		}

		public TooManyRequestsException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public TooManyRequestsException(Exception innerException)
			: base((string)null)
		{
		}

		public TooManyRequestsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public TooManyRequestsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
