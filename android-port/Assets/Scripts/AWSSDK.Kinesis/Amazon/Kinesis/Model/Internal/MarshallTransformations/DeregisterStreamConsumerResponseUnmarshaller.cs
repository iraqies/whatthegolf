using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class DeregisterStreamConsumerResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static DeregisterStreamConsumerResponseUnmarshaller _instance;

		public static DeregisterStreamConsumerResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static DeregisterStreamConsumerResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
