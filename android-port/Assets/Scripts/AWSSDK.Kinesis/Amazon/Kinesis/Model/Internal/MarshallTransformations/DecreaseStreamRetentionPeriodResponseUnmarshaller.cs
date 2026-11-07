using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class DecreaseStreamRetentionPeriodResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static DecreaseStreamRetentionPeriodResponseUnmarshaller _instance;

		public static DecreaseStreamRetentionPeriodResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static DecreaseStreamRetentionPeriodResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
