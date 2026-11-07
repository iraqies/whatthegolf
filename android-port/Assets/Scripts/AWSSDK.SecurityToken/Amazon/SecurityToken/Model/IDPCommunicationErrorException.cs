using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	public class IDPCommunicationErrorException : AmazonSecurityTokenServiceException
	{
		public IDPCommunicationErrorException(string message)
			: base((string)null)
		{
		}

		public IDPCommunicationErrorException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public IDPCommunicationErrorException(Exception innerException)
			: base((string)null)
		{
		}

		public IDPCommunicationErrorException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public IDPCommunicationErrorException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
