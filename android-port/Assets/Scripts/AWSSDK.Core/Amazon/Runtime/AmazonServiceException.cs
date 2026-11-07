using System;
using System.Net;

namespace Amazon.Runtime
{
	public class AmazonServiceException : Exception
	{
		private ErrorType errorType;

		private string errorCode;

		private string requestId;

		private HttpStatusCode statusCode;

		public ErrorType ErrorType
		{
			get
			{
				return ErrorType.Sender;
			}
			set
			{
			}
		}

		public string ErrorCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string RequestId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HttpStatusCode StatusCode
		{
			get
			{
				return (HttpStatusCode)0;
			}
			set
			{
			}
		}

		public virtual RetryableDetails Retryable => null;

		public AmazonServiceException()
		{
		}

		public AmazonServiceException(string message)
		{
		}

		public AmazonServiceException(string message, Exception innerException)
		{
		}

		public AmazonServiceException(string message, Exception innerException, HttpStatusCode statusCode)
		{
		}

		public AmazonServiceException(Exception innerException)
		{
		}

		public AmazonServiceException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public AmazonServiceException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		private static string BuildGenericErrorMessage(string errorCode, HttpStatusCode statusCode)
		{
			return null;
		}
	}
}
