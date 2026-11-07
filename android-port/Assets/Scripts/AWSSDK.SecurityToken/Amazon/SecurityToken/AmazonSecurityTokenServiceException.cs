using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.SecurityToken
{
	public class AmazonSecurityTokenServiceException : AmazonServiceException
	{
		public AmazonSecurityTokenServiceException(string message)
		{
		}

		public AmazonSecurityTokenServiceException(string message, Exception innerException)
		{
		}

		public AmazonSecurityTokenServiceException(Exception innerException)
		{
		}

		public AmazonSecurityTokenServiceException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public AmazonSecurityTokenServiceException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
