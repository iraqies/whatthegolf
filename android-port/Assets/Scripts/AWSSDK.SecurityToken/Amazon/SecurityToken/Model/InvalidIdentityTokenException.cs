using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	public class InvalidIdentityTokenException : AmazonSecurityTokenServiceException
	{
		public InvalidIdentityTokenException(string message)
			: base((string)null)
		{
		}

		public InvalidIdentityTokenException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidIdentityTokenException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidIdentityTokenException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidIdentityTokenException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
