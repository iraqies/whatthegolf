using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	public class PackedPolicyTooLargeException : AmazonSecurityTokenServiceException
	{
		public PackedPolicyTooLargeException(string message)
			: base((string)null)
		{
		}

		public PackedPolicyTooLargeException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public PackedPolicyTooLargeException(Exception innerException)
			: base((string)null)
		{
		}

		public PackedPolicyTooLargeException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public PackedPolicyTooLargeException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
