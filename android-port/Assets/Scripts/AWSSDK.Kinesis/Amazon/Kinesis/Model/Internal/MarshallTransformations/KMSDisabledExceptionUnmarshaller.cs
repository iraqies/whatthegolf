using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class KMSDisabledExceptionUnmarshaller : IErrorResponseUnmarshaller<KMSDisabledException, JsonUnmarshallerContext>, IUnmarshaller<KMSDisabledException, JsonUnmarshallerContext>
	{
		private static KMSDisabledExceptionUnmarshaller _instance;

		public static KMSDisabledExceptionUnmarshaller Instance => null;

		public KMSDisabledException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public KMSDisabledException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
