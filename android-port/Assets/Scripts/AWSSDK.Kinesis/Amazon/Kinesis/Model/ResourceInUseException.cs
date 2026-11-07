using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class ResourceInUseException : AmazonKinesisException
	{
		public ResourceInUseException(string message)
			: base((string)null)
		{
		}

		public ResourceInUseException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public ResourceInUseException(Exception innerException)
			: base((string)null)
		{
		}

		public ResourceInUseException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public ResourceInUseException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
