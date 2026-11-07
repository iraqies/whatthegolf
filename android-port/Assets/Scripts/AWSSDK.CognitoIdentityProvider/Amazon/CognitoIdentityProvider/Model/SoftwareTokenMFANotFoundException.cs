using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class SoftwareTokenMFANotFoundException : AmazonCognitoIdentityProviderException
	{
		public SoftwareTokenMFANotFoundException(string message)
			: base((string)null)
		{
		}

		public SoftwareTokenMFANotFoundException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public SoftwareTokenMFANotFoundException(Exception innerException)
			: base((string)null)
		{
		}

		public SoftwareTokenMFANotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public SoftwareTokenMFANotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
