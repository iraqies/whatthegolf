using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UserImportInProgressException : AmazonCognitoIdentityProviderException
	{
		public UserImportInProgressException(string message)
			: base((string)null)
		{
		}

		public UserImportInProgressException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public UserImportInProgressException(Exception innerException)
			: base((string)null)
		{
		}

		public UserImportInProgressException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public UserImportInProgressException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
