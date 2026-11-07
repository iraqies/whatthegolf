using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class KMSInvalidStateExceptionUnmarshaller : IErrorResponseUnmarshaller<KMSInvalidStateException, JsonUnmarshallerContext>, IUnmarshaller<KMSInvalidStateException, JsonUnmarshallerContext>
	{
		private static KMSInvalidStateExceptionUnmarshaller _instance;

		public static KMSInvalidStateExceptionUnmarshaller Instance => null;

		public KMSInvalidStateException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public KMSInvalidStateException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
