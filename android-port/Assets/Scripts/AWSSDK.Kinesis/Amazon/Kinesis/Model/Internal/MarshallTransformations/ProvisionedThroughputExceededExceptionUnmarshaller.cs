using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class ProvisionedThroughputExceededExceptionUnmarshaller : IErrorResponseUnmarshaller<ProvisionedThroughputExceededException, JsonUnmarshallerContext>, IUnmarshaller<ProvisionedThroughputExceededException, JsonUnmarshallerContext>
	{
		private static ProvisionedThroughputExceededExceptionUnmarshaller _instance;

		public static ProvisionedThroughputExceededExceptionUnmarshaller Instance => null;

		public ProvisionedThroughputExceededException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public ProvisionedThroughputExceededException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
