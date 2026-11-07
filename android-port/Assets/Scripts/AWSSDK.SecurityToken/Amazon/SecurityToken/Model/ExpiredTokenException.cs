using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	public class ExpiredTokenException : AmazonSecurityTokenServiceException
	{
		public ExpiredTokenException(string message)
			: base((string)null)
		{
		}

		public ExpiredTokenException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public ExpiredTokenException(Exception innerException)
			: base((string)null)
		{
		}

		public ExpiredTokenException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public ExpiredTokenException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
