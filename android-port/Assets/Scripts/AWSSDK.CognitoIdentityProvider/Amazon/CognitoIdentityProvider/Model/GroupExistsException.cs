using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class GroupExistsException : AmazonCognitoIdentityProviderException
	{
		public GroupExistsException(string message)
			: base((string)null)
		{
		}

		public GroupExistsException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public GroupExistsException(Exception innerException)
			: base((string)null)
		{
		}

		public GroupExistsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public GroupExistsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
