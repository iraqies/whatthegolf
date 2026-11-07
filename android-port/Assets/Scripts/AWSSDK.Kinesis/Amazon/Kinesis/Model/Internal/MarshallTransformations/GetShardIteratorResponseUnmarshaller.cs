using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class GetShardIteratorResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static GetShardIteratorResponseUnmarshaller _instance;

		public static GetShardIteratorResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static GetShardIteratorResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
