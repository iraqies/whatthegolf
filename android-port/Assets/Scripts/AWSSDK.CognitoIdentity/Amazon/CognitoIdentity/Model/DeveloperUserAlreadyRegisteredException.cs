using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentity.Model
{
	public class DeveloperUserAlreadyRegisteredException : AmazonCognitoIdentityException
	{
		public DeveloperUserAlreadyRegisteredException(string message)
			: base((string)null)
		{
		}

		public DeveloperUserAlreadyRegisteredException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public DeveloperUserAlreadyRegisteredException(Exception innerException)
			: base((string)null)
		{
		}

		public DeveloperUserAlreadyRegisteredException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public DeveloperUserAlreadyRegisteredException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
