using System;
using System.Net;
using System.Text;

namespace Amazon.Runtime
{
	public class AmazonUnmarshallingException : AmazonServiceException
	{
		public string LastKnownLocation { get; private set; }

		public string ResponseBody { get; private set; }

		public override string Message => null;

		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, Exception innerException)
		{
		}

		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, Exception innerException)
		{
		}

		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string message, Exception innerException)
		{
		}

		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, Exception innerException, HttpStatusCode statusCode)
		{
		}

		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, Exception innerException, HttpStatusCode statusCode)
		{
		}

		private static void AppendFormat(StringBuilder sb, string format, string value)
		{
		}
	}
}
