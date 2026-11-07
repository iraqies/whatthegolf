using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class InvalidSmsRoleTrustRelationshipException : AmazonCognitoIdentityProviderException
	{
		public InvalidSmsRoleTrustRelationshipException(string message)
			: base((string)null)
		{
		}

		public InvalidSmsRoleTrustRelationshipException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidSmsRoleTrustRelationshipException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidSmsRoleTrustRelationshipException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidSmsRoleTrustRelationshipException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
