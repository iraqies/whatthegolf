using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class IncreaseStreamRetentionPeriodResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static IncreaseStreamRetentionPeriodResponseUnmarshaller _instance;

		public static IncreaseStreamRetentionPeriodResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static IncreaseStreamRetentionPeriodResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
