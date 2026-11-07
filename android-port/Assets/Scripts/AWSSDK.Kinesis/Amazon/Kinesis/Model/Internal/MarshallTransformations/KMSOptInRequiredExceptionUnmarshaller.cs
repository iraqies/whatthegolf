using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class KMSOptInRequiredExceptionUnmarshaller : IErrorResponseUnmarshaller<KMSOptInRequiredException, JsonUnmarshallerContext>, IUnmarshaller<KMSOptInRequiredException, JsonUnmarshallerContext>
	{
		private static KMSOptInRequiredExceptionUnmarshaller _instance;

		public static KMSOptInRequiredExceptionUnmarshaller Instance => null;

		public KMSOptInRequiredException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public KMSOptInRequiredException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
