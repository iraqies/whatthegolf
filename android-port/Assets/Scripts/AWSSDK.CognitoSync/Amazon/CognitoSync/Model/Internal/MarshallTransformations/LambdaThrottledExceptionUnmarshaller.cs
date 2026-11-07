using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	public class LambdaThrottledExceptionUnmarshaller : IErrorResponseUnmarshaller<LambdaThrottledException, JsonUnmarshallerContext>, IUnmarshaller<LambdaThrottledException, JsonUnmarshallerContext>
	{
		private static LambdaThrottledExceptionUnmarshaller _instance;

		public static LambdaThrottledExceptionUnmarshaller Instance => null;

		public LambdaThrottledException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public LambdaThrottledException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
