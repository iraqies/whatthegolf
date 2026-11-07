using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	public class MalformedPolicyDocumentException : AmazonSecurityTokenServiceException
	{
		public MalformedPolicyDocumentException(string message)
			: base((string)null)
		{
		}

		public MalformedPolicyDocumentException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public MalformedPolicyDocumentException(Exception innerException)
			: base((string)null)
		{
		}

		public MalformedPolicyDocumentException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public MalformedPolicyDocumentException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
