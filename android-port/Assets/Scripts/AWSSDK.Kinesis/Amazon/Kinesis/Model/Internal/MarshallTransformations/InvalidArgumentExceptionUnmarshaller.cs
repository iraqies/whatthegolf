using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class InvalidArgumentExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidArgumentException, JsonUnmarshallerContext>, IUnmarshaller<InvalidArgumentException, JsonUnmarshallerContext>
	{
		private static InvalidArgumentExceptionUnmarshaller _instance;

		public static InvalidArgumentExceptionUnmarshaller Instance => null;

		public InvalidArgumentException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public InvalidArgumentException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
