using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class MergeShardsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static MergeShardsResponseUnmarshaller _instance;

		public static MergeShardsResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static MergeShardsResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
