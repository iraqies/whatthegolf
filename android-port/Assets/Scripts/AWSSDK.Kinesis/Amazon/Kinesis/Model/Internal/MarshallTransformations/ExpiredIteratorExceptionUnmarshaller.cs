using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class ExpiredIteratorExceptionUnmarshaller : IErrorResponseUnmarshaller<ExpiredIteratorException, JsonUnmarshallerContext>, IUnmarshaller<ExpiredIteratorException, JsonUnmarshallerContext>
	{
		private static ExpiredIteratorExceptionUnmarshaller _instance;

		public static ExpiredIteratorExceptionUnmarshaller Instance => null;

		public ExpiredIteratorException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public ExpiredIteratorException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
