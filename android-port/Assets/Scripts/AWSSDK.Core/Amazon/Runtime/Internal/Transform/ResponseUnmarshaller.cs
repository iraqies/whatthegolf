using System;
using System.IO;
using System.Net;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Transform
{
	public abstract class ResponseUnmarshaller : IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext>, IUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext>
	{
		public virtual bool HasStreamingProperty => false;

		public virtual UnmarshallerContext CreateContext(IWebResponseData response, bool readEntireResponse, Stream stream, RequestMetrics metrics, bool isException)
		{
			return null;
		}

		public virtual AmazonServiceException UnmarshallException(UnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		public AmazonWebServiceResponse UnmarshallResponse(UnmarshallerContext context)
		{
			return null;
		}

		public abstract AmazonWebServiceResponse Unmarshall(UnmarshallerContext input);

		public static string GetDefaultErrorMessage<T>() where T : Exception
		{
			return null;
		}

		protected abstract UnmarshallerContext ConstructUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData response, bool isException);

		protected virtual bool ShouldReadEntireResponse(IWebResponseData response, bool readEntireResponse)
		{
			return false;
		}
	}
}
