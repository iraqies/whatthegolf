using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class KMSNotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<KMSNotFoundException, JsonUnmarshallerContext>, IUnmarshaller<KMSNotFoundException, JsonUnmarshallerContext>
	{
		private static KMSNotFoundExceptionUnmarshaller _instance;

		public static KMSNotFoundExceptionUnmarshaller Instance => null;

		public KMSNotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public KMSNotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
