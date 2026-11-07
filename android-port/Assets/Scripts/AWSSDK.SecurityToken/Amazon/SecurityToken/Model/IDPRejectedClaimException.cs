using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	public class IDPRejectedClaimException : AmazonSecurityTokenServiceException
	{
		public IDPRejectedClaimException(string message)
			: base((string)null)
		{
		}

		public IDPRejectedClaimException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public IDPRejectedClaimException(Exception innerException)
			: base((string)null)
		{
		}

		public IDPRejectedClaimException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public IDPRejectedClaimException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
