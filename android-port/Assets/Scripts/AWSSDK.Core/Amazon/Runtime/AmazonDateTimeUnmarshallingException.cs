using System;

namespace Amazon.Runtime
{
	public class AmazonDateTimeUnmarshallingException : AmazonUnmarshallingException
	{
		public string InvalidDateTimeToken { get; private set; }

		public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string invalidDateTimeToken, Exception innerException)
			: base(null, null, null)
		{
		}

		public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string invalidDateTimeToken, Exception innerException)
			: base(null, null, null)
		{
		}

		public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string invalidDateTimeToken, string message, Exception innerException)
			: base(null, null, null)
		{
		}
	}
}
