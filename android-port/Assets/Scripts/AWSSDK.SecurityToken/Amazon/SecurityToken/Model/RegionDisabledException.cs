using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	public class RegionDisabledException : AmazonSecurityTokenServiceException
	{
		public RegionDisabledException(string message)
			: base((string)null)
		{
		}

		public RegionDisabledException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public RegionDisabledException(Exception innerException)
			: base((string)null)
		{
		}

		public RegionDisabledException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public RegionDisabledException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
