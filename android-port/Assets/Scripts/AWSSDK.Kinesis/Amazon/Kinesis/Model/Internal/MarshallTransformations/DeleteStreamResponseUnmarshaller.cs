using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class DeleteStreamResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static DeleteStreamResponseUnmarshaller _instance;

		public static DeleteStreamResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static DeleteStreamResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
