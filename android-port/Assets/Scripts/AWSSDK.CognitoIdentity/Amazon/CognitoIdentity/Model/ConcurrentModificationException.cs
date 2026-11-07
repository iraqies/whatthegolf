using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentity.Model
{
	public class ConcurrentModificationException : AmazonCognitoIdentityException
	{
		public ConcurrentModificationException(string message)
			: base((string)null)
		{
		}

		public ConcurrentModificationException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public ConcurrentModificationException(Exception innerException)
			: base((string)null)
		{
		}

		public ConcurrentModificationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public ConcurrentModificationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
