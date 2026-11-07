using System.Net;

namespace Amazon.Runtime
{
	public class AmazonWebServiceResponse
	{
		private ResponseMetadata responseMetadataField;

		private long contentLength;

		private HttpStatusCode httpStatusCode;

		public ResponseMetadata ResponseMetadata
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long ContentLength
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public HttpStatusCode HttpStatusCode
		{
			get
			{
				return (HttpStatusCode)0;
			}
			set
			{
			}
		}
	}
}
