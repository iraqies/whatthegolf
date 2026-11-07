using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UsernameExistsException : AmazonCognitoIdentityProviderException
	{
		public UsernameExistsException(string message)
			: base((string)null)
		{
		}

		public UsernameExistsException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public UsernameExistsException(Exception innerException)
			: base((string)null)
		{
		}

		public UsernameExistsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public UsernameExistsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
