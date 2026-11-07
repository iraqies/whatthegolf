using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class KMSThrottlingExceptionUnmarshaller : IErrorResponseUnmarshaller<KMSThrottlingException, JsonUnmarshallerContext>, IUnmarshaller<KMSThrottlingException, JsonUnmarshallerContext>
	{
		private static KMSThrottlingExceptionUnmarshaller _instance;

		public static KMSThrottlingExceptionUnmarshaller Instance => null;

		public KMSThrottlingException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public KMSThrottlingException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
