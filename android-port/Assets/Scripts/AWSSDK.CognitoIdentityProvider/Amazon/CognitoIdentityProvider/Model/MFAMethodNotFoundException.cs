using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class MFAMethodNotFoundException : AmazonCognitoIdentityProviderException
	{
		public MFAMethodNotFoundException(string message)
			: base((string)null)
		{
		}

		public MFAMethodNotFoundException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public MFAMethodNotFoundException(Exception innerException)
			: base((string)null)
		{
		}

		public MFAMethodNotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public MFAMethodNotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
