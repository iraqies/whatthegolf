using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class KMSAccessDeniedExceptionUnmarshaller : IErrorResponseUnmarshaller<KMSAccessDeniedException, JsonUnmarshallerContext>, IUnmarshaller<KMSAccessDeniedException, JsonUnmarshallerContext>
	{
		private static KMSAccessDeniedExceptionUnmarshaller _instance;

		public static KMSAccessDeniedExceptionUnmarshaller Instance => null;

		public KMSAccessDeniedException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public KMSAccessDeniedException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
