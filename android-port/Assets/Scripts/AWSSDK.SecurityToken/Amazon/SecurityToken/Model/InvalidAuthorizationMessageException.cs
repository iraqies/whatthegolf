using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	public class InvalidAuthorizationMessageException : AmazonSecurityTokenServiceException
	{
		public InvalidAuthorizationMessageException(string message)
			: base((string)null)
		{
		}

		public InvalidAuthorizationMessageException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidAuthorizationMessageException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidAuthorizationMessageException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidAuthorizationMessageException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
