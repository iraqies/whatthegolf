using System;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Runtime.Internal
{
	public class HttpErrorResponseException : Exception
	{
		public IWebResponseData Response { get; private set; }

		public HttpErrorResponseException(IWebResponseData response)
		{
		}

		public HttpErrorResponseException(string message, IWebResponseData response)
		{
		}

		public HttpErrorResponseException(string message, Exception innerException, IWebResponseData response)
		{
		}
	}
}
