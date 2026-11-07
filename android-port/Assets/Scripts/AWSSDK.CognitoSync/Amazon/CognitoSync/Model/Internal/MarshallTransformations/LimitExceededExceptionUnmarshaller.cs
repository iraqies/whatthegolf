using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	public class LimitExceededExceptionUnmarshaller : IErrorResponseUnmarshaller<LimitExceededException, JsonUnmarshallerContext>, IUnmarshaller<LimitExceededException, JsonUnmarshallerContext>
	{
		private static LimitExceededExceptionUnmarshaller _instance;

		public static LimitExceededExceptionUnmarshaller Instance => null;

		public LimitExceededException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public LimitExceededException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
