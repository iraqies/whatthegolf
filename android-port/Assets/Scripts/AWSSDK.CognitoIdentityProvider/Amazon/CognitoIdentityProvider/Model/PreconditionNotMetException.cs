using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class PreconditionNotMetException : AmazonCognitoIdentityProviderException
	{
		public PreconditionNotMetException(string message)
			: base((string)null)
		{
		}

		public PreconditionNotMetException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public PreconditionNotMetException(Exception innerException)
			: base((string)null)
		{
		}

		public PreconditionNotMetException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public PreconditionNotMetException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
