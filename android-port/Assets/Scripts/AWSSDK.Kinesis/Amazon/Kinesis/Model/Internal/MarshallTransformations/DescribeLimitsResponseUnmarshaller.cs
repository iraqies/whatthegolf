using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class DescribeLimitsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static DescribeLimitsResponseUnmarshaller _instance;

		public static DescribeLimitsResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static DescribeLimitsResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
