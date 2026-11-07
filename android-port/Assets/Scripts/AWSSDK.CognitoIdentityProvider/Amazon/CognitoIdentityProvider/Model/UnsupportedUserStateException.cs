using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UnsupportedUserStateException : AmazonCognitoIdentityProviderException
	{
		public UnsupportedUserStateException(string message)
			: base((string)null)
		{
		}

		public UnsupportedUserStateException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public UnsupportedUserStateException(Exception innerException)
			: base((string)null)
		{
		}

		public UnsupportedUserStateException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public UnsupportedUserStateException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
