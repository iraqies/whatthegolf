using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class RemoveTagsFromStreamResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static RemoveTagsFromStreamResponseUnmarshaller _instance;

		public static RemoveTagsFromStreamResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static RemoveTagsFromStreamResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
