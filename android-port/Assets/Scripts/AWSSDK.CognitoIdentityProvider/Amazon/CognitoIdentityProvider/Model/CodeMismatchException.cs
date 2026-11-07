using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CodeMismatchException : AmazonCognitoIdentityProviderException
	{
		public CodeMismatchException(string message)
			: base((string)null)
		{
		}

		public CodeMismatchException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public CodeMismatchException(Exception innerException)
			: base((string)null)
		{
		}

		public CodeMismatchException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public CodeMismatchException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
