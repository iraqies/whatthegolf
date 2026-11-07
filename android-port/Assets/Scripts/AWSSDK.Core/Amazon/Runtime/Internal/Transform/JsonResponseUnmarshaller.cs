using System;
using System.IO;
using System.Net;

namespace Amazon.Runtime.Internal.Transform
{
	public abstract class JsonResponseUnmarshaller : ResponseUnmarshaller
	{
		public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(UnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		public abstract AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext input);

		public abstract AmazonServiceException UnmarshallException(JsonUnmarshallerContext input, Exception innerException, HttpStatusCode statusCode);

		protected override UnmarshallerContext ConstructUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData response, bool isException)
		{
			return null;
		}

		protected override bool ShouldReadEntireResponse(IWebResponseData response, bool readEntireResponse)
		{
			return false;
		}
	}
}
