using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	public class ConcurrentModificationExceptionUnmarshaller : IErrorResponseUnmarshaller<ConcurrentModificationException, JsonUnmarshallerContext>, IUnmarshaller<ConcurrentModificationException, JsonUnmarshallerContext>
	{
		private static ConcurrentModificationExceptionUnmarshaller _instance;

		public static ConcurrentModificationExceptionUnmarshaller Instance => null;

		public ConcurrentModificationException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public ConcurrentModificationException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
